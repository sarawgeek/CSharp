dotnet run
if($LastExitCode -eq 0){
	Write-Host 	"Execution Succeded"
} else
{
	Write-Host "Execution Failed"
}

Write-Host "Return Value = " $LastExitCode
