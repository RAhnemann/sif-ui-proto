using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace SIF_UI_Proto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Parameter
        {
            public string Name { get; set; }

            public string DefaultValue { get; set; }

            public string Value { get; set; }

            public string CalculatedValue { get; set; }

            public string Description { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public class Variable
        {
            public string Name { get; set; }
            public string Value { get; set; }

            public string CalculatedValue { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public class Task
        {
            public string Name { get; set; }

            public string TaskType { get; set; }

            public IDictionary<String, Object> Parameters { get; set; }

            public override string ToString()
            {
                return $"{Name} - {TaskType}";
            }
        }

        private List<Parameter> _parameters = new List<Parameter>();
        private List<Variable> _variables = new List<Variable>();
        private List<Task> _tasks = new List<Task>();

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = @"D:\Sitecore9\9.0.1\XM\sitecore-XM1-cm.json";

            dynamic json =
                JsonConvert.DeserializeObject<ExpandoObject>(File.ReadAllText(path), new ExpandoObjectConverter());

            var parameters = json.Parameters;
            var variables = json.Variables;
            var tasks = json.Tasks;



            foreach (var param in parameters)
            {
                var pValue = (IDictionary<String, Object>)param.Value;
                object defaultValue;
                pValue.TryGetValue("DefaultValue", out defaultValue);

                _parameters.Add(new Parameter
                {
                    Name = param.Key,
                    DefaultValue = defaultValue?.ToString(),
                    Value = defaultValue?.ToString(),
                    CalculatedValue = defaultValue?.ToString(),
                    Description = pValue["Description"].ToString()
                });

            }

            foreach (var variable in variables)
            {
                _variables.Add(new Variable()
                {
                    Name = variable.Key,
                    Value = variable.Value,
                    CalculatedValue = variable.Value
                });
            }

            foreach (var task in tasks)
            {
                _tasks.Add(new Task()
                {
                    Name = task.Key,
                    TaskType = task.Value.Type,
                    Parameters = (IDictionary<String, Object>)task.Value.Params
                });
            }

            //Replace Parameters
            foreach (var variable in _variables)
            {
                var regexMatch = Regex.Match(variable.Value, @"parameter\('(.*?)'\)");

                if (regexMatch.Success)
                {
                    var parameter = _parameters.Find(v => v.Name == regexMatch.Groups[1].Value);

                    variable.CalculatedValue =
                        variable.Value.Replace(regexMatch.Value, $"'{parameter.CalculatedValue}'");
                }
            }

            //fix concats
            foreach (var variable in _variables)
            {
                variable.CalculatedValue = Compute(variable.Value);
            }

            foreach (var parameter in _parameters)
            {
                parameterListBox.Items.Add(parameter);
            }


            foreach (var variable in _variables)
            {
                variablesListBox.Items.Add(variable);
            }


            foreach (var task in _tasks)
            {
                tasksListBox.Items.Add(task);
            }

            HideDetailsPanels();
            variableInfoGroupBox.Location = parameterInfoGroupBox.Location;
            taskInfoGroupBox.Location = parameterInfoGroupBox.Location;
        }


        public string Compute(string input)
        {
            var computedText = input;

            computedText = computedText.Replace("environment('SystemDrive')", Path.GetPathRoot(Environment.SystemDirectory));
            computedText = computedText.Replace("environment(SystemDrive)", Path.GetPathRoot(Environment.SystemDirectory));
            foreach (var parameter in _parameters)
            {
                computedText = computedText.Replace($"parameter('{parameter.Name}')", parameter.CalculatedValue);
            }

            foreach (var variable in _variables)
            {
                computedText = computedText.Replace($"variable('{variable.Name}')", variable.CalculatedValue);
            }

            var concatRegex = Regex.Match(computedText, @"concat\('?(.*?)'?, ?'?(.*?)'?\)");

            if (concatRegex.Success)
                computedText = computedText.Replace(concatRegex.Value, $"{concatRegex.Groups[1].Value}{concatRegex.Groups[2].Value}");

            if (computedText.StartsWith("[") && computedText.EndsWith("]"))
                computedText = computedText.Substring(1, computedText.Length - 2);

            var joinRegex = Regex.Match(computedText, @"joinpath\((.*?)\)");

            if (joinRegex.Success)
            {
                var splits = joinRegex.Value.Split(',').ToList();

                for (var i = 0; i <= splits.Count - 1; i++)
                {

                    splits[i] = splits[i].Trim().Replace("'", "");

                    if (i == 0)
                        splits[0] = splits[0].Replace("joinpath(", "");

                    if (i == splits.Count - 1)
                        splits[i] = splits[i].Substring(0, splits[i].Length - 1);
                }

                computedText = computedText.Replace(joinRegex.Value, string.Join("\\", splits)).Replace("\\\\", "\\");
            }

            return computedText;
        }

        public class Item
        {
            public string language { get; set; }
            public string title { get; set; }
            public string uri { get; set; }

            public string url { get; set; }
            public string nid { get; set; }

        }

        public class ItemDeets
        {
            public string path { get; set; }

            public string nid { get; set; }


        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var items = new List<Item>();

        //    var text = GetJson("http://mitel.dev8.zivtech.com/rest/export/node.json?parameters%5btype%5d=blog&page=1");

        //    var itemsParsed = JsonConvert.DeserializeObject<List<Item>>(text);

        //    items.AddRange(itemsParsed);
        //    int page = 0;
        //    while (itemsParsed.Count > 0)
        //    {

        //        items.AddRange(itemsParsed);
        //        page++;
        //        text = GetJson($"http://mitel.dev8.zivtech.com/rest/export/node.json?parameters%5btype%5d=blog&page={page}");

        //        itemsParsed = JsonConvert.DeserializeObject<List<Item>>(text);

        //    }

        //    foreach (var item in items)
        //    {
        //        var content = GetJson(item.uri);
        //        var deets = JsonConvert.DeserializeObject<ItemDeets>(content);

        //        item.url = deets.path.Replace(".dev8.zivtech", "");
        //        item.nid = deets.nid;

        //    }

        //    StringBuilder output = new StringBuilder();

        //    foreach (var item in items)
        //    {
        //        output.AppendFormat("{0},{1},{2},{3}\r\n", item.nid, item.language, item.url, item.title);
        //    }

        //    File.WriteAllText($@"C:\temp\{Guid.NewGuid().ToString()}.csv", output.ToString());
        //}

        //public string GetJson(string url)
        //{
        //    using (var client = new WebClient())
        //    {
        //        client.Credentials = new NetworkCredential("zivtech", "zivtech");
        //        return client.DownloadString(url);

        //    }
        //}

        private void HideDetailsPanels()
        {
            parameterInfoGroupBox.Visible = false;
            variableInfoGroupBox.Visible = false;
            taskInfoGroupBox.Visible = false;
        }

        private void ResetVariableListBox()
        {
            variablesListBox.SelectedIndexChanged -= variablesListBox_SelectedIndexChanged;
            variablesListBox.SelectedIndex = -1;
            variablesListBox.SelectedIndexChanged += variablesListBox_SelectedIndexChanged;
        }

        private void ResetParameterListBox()
        {
            parameterListBox.SelectedIndexChanged -= parameterListBox_SelectedIndexChanged;
            parameterListBox.SelectedIndex = -1;
            parameterListBox.SelectedIndexChanged += parameterListBox_SelectedIndexChanged;
        }

        private void ResetTaskListBox()
        {
            tasksListBox.SelectedIndexChanged -= tasksListBox_SelectedIndexChanged;
            tasksListBox.SelectedIndex = -1;
            tasksListBox.SelectedIndexChanged += tasksListBox_SelectedIndexChanged;
        }

        private void parameterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetVariableListBox();
            ResetTaskListBox();

            HideDetailsPanels();

            ShowParameterInfo((Parameter)parameterListBox.SelectedItem);

        }

        private void variablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetParameterListBox();
            ResetTaskListBox();

            HideDetailsPanels();

            ShowVariableInfo((Variable)variablesListBox.SelectedItem);
        }


        private void tasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetParameterListBox();
            ResetVariableListBox();

            HideDetailsPanels();

            ShowTaskInfo((Task)tasksListBox.SelectedItem);
        }

        private void ShowVariableInfo(Variable variable)
        {
            variableInfoGroupBox.Visible = true;
            variableNameLabel.Text = variable.Name;
            variableOriginalValueLabel.Text = variable.Value;
            variableCalcdValueLabel.Text = variable.CalculatedValue;
        }

        private void ShowParameterInfo(Parameter parameter)
        {
            parameterInfoGroupBox.Visible = true;
            parameterNameLabel.Text = parameter.Name;
            parameterDefaultLabel.Text = parameter.DefaultValue;
            parameterDescriptionLabel.Text = parameter.Description;
        }

        private void ShowTaskInfo(Task task)
        {
            taskInfoGroupBox.Visible = true;
            taskNameLabel.Text = task.Name;
            taskTypeLabel.Text = task.TaskType;

            taskParametersTree.Nodes.Clear();
            var root = taskParametersTree.Nodes.Add("Parameters");
            foreach (var parameter in task.Parameters)
            {
                var paramNode = root.Nodes.Add(parameter.Key);

                if (parameter.Value is ExpandoObject)
                {
                    AddParamNodes(paramNode, (IDictionary<string, object>)parameter.Value);
                }
                else
                {
                    var value = "";
                    if (parameter.Value is List<object> eList && eList[0] is ExpandoObject)
                    {
                        foreach (var exp in eList)
                        {
                            AddParamNodes(paramNode, (ExpandoObject)exp);
                        }
                    }
                    else if (parameter.Value is List<object> sList)
                    {
                        paramNode.Text = $"{parameter.Key} - {Compute(sList[0].ToString())}";
                    }
                    else
                    {
                        value = parameter.Value.ToString();
                        paramNode.Text = $"{parameter.Key} --- {Compute(value)}";
                        paramNode.ToolTipText = $"Original Value: {value}";
                    }



                }

            }

            taskParametersTree.ExpandAll();
        }

        private void AddParamNodes(TreeNode parent, IDictionary<string, object> param)
        {
            var dictionary = param;

            if (dictionary != null)
            {
                foreach (var set in dictionary)
                {
                    var keyNode = parent.Nodes.Add(set.Key);

                    if (set.Value is IDictionary<string, object> dictValue)
                    {
                        AddParamNodes(keyNode, dictValue);
                    }
                    else if (set.Value is ExpandoObject internalDict)
                    {
                        foreach (var internalSet in internalDict)
                        {
                            var internalNode = keyNode.Nodes.Add(internalSet.Key);

                            AddParamNodes(internalNode, (IDictionary<string, object>)internalSet.Value);
                        }

                    }
                    else if (set.Value is List<object> eValue && eValue[0] is ExpandoObject)
                    {
                        // var arrayNode = keyNode.Nodes.Add("[]");
                        foreach (var exp in eValue)
                        {
                            AddParamNodes(keyNode, (ExpandoObject)exp);
                        }
                    }
                    else if (set.Value is List<object> value)
                    {
                        keyNode.Text = $"{set.Key} -+- {Compute(value[0].ToString())}";
                    }
                    else
                    {
                        keyNode.Text = $"{set.Key} ----- {Compute(set.Value.ToString())}";
                    }
                }
            }
        }

    }
}
