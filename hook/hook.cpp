#include <windows.h>
#include <iostream>
#include <TlHelp32.h>
#include <TlHelp32.h>


using namespace std;

int main()
{
	PROCESS_INFORMATION pi;
	STARTUPINFOA si;
	ZeroMemory(&si, sizeof(STARTUPINFOA));
	si.cb = sizeof(STARTUPINFOA);
	if (!CreateProcessA(NULL, LPSTR("C:\\prot2.exe"), NULL, NULL, false, CREATE_SUSPENDED, NULL, NULL, &si, &pi))
	{
		cout << "CreateProcess failed: " << GetLastError() << endl;
		cin.get();
		return NULL;
	}
	else
	{
		//нужный тебе процесс стартанул замороженым

		HANDLE hProcess = pi.hProcess;

		BYTE* b = (BYTE*)"\x75\x05";
		WriteProcessMemory(hProcess, (void*)0xDC104C, &b, 2, 0);

		CloseHandle(hProcess);
		ResumeThread(pi.hThread);
		CloseHandle(pi.hThread);
	}

	return 0;
}