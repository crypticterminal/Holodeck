#include "common.h"


BOOL My_GetTimeFormatW()
{
	LCID Locale=NULL;
	DWORD dwFlags=NULL;
	CONST SYSTEMTIME * lpTime=NULL;
	LPCWSTR lpFormat=NULL;
	LPWSTR lpTimeStr=NULL;
	int cchTime=NULL;
	int returnVal_Real = NULL;
	int returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	disableInterception();
	returnVal_Real = GetTimeFormatW (Locale,dwFlags,lpTime,lpFormat,lpTimeStr,cchTime);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = GetTimeFormatW (Locale,dwFlags,lpTime,lpFormat,lpTimeStr,cchTime);
	error_Intercepted = GetLastError();
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}