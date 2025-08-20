# PowerShell script to normalize line endings for .NET project

Write-Host "Normalizing line endings for .NET project..." -ForegroundColor Green

# Get all C# files
$csFiles = Get-ChildItem -Path . -Recurse -Filter "*.cs"

foreach ($file in $csFiles) {
    Write-Host "Processing: $($file.FullName)" -ForegroundColor Yellow
    
    # Read file content
    $content = Get-Content -Path $file.FullName -Raw
    
    # Normalize line endings to LF and ensure single newline at end
    $normalizedContent = $content -replace "`r`n", "`n" -replace "`n+$", "`n"
    
    # Write back to file with UTF-8 encoding and LF line endings
    [System.IO.File]::WriteAllText($file.FullName, $normalizedContent, [System.Text.Encoding]::UTF8)
}

Write-Host "Line endings normalized successfully!" -ForegroundColor Green
Write-Host "All .cs files now have Unix line endings (LF) and single newline at end." -ForegroundColor Green
