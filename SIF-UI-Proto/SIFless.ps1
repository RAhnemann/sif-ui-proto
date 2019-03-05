
if ([Environment]::Is64BitProcess) {
    Write-Host "64x"
}
    Write-Information "Test-Before"
    
    Get-WebBinding
    Write-Information "Test-After"
    Write-Information "This too"
    