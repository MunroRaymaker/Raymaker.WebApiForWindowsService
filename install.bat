sc create ContosoWebApi binPath= %~dp0ContosoWebApi.exe
sc failure ContosoWebApi actions= restart/60000/restart/60000/""/60000 reset= 86400
sc start ContosoWebApi
sc config ContosoWebApi start=auto