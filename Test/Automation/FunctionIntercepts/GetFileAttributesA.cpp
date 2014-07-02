#include "common.h"


BOOL My_GetFileAttributesA()
{
	LPCSTR lpFileName=NULL;
	DWORD returnVal_Real = NULL;
	DWORD returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	__try{
	disableInterception();
	returnVal_Real = GetFileAttributesA (lpFileName);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = GetFileAttributesA (lpFileName);
	error_Intercepted = GetLastError();
	}__except(puts("in filter"), 1){puts("exception caught");}
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}