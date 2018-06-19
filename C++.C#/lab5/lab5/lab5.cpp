// lab5.cpp : Defines the entry point for the application.
//

#include "stdafx.h"
#include "lab5.h"

#define MAX_LOADSTRING 100

// Global Variables:
HINSTANCE hInst;                                // current instance
WCHAR szTitle[MAX_LOADSTRING];                  // The title bar text
WCHAR szWindowClass[MAX_LOADSTRING];            // the main window class name

// Forward declarations of functions included in this code module:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // TODO: Place code here.
		
    // Initialize global strings
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_LAB5, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Perform application initialization:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_LAB5));

    MSG msg;

    // Main message loop:
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

    return (int) msg.wParam;
}



//
//  FUNCTION: MyRegisterClass()
//
//  PURPOSE: Registers the window class.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_LAB5));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_LAB5);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}

//
//   FUNCTION: InitInstance(HINSTANCE, int)
//
//   PURPOSE: Saves instance handle and creates main window
//
//   COMMENTS:
//
//        In this function, we save the instance handle in a global variable and
//        create and display the main program window.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Store instance handle in our global variable

   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, nullptr, nullptr, hInstance, nullptr);

   if (!hWnd)
   {
      return FALSE;
   }

   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);

   return TRUE;
}

//
//  FUNCTION: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  PURPOSE:  Processes messages for the main window.
//
//  WM_COMMAND  - process the application menu
//  WM_PAINT    - Paint the main window
//  WM_DESTROY  - post a quit message and return
//
//
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	int wmId, wmEvent;
	PAINTSTRUCT ps;
	RECT rect;
	GetClientRect(hWnd, &rect);
	HDC hdc;
	HBRUSH hBrush;
	LOGBRUSH lb;
	HBRUSH holdBrush;
	static CIRCLE wheel_00(800, 250, 150, 125, RGB(255, 150, 1));
	static CIRCLE wheel_10(320, 250, 150, 125, RGB(255, 150, 1));
	static LINE bottom_0(200, 300, 0, 210, RGB(0, 0, 0));
	static LINE bottom_1(450, 300, 0, 470, RGB(30, 30, 255));
	static LINE face_1(200, 300, -100, 0, RGB(0, 0, 0));
	static LINE face_2(200, 200, -100, 210, RGB(0, 0, 0));
	static LINE face_3(410, 300, -200, 0, RGB(0, 05, 0));
	static LINE face_21(450, 300, -250, 0, RGB(30, 30, 255));
	static LINE face_22(920, 300, -250, 0, RGB(30, 30, 255));
	static LINE face_23(450, 50, 0, 470, RGB(30, 30, 255));
	static LINE connect_1(410, 200, 0, 40, RGB(255, 128, 114));
	static LINE connect_2(410, 290, 0, 40, RGB(255, 128, 114));
	static LINE cross_1(450, 300, -250, 470, RGB(255, 215, 0));
	static LINE cross_2(450, 50, 250, 470, RGB(255, 215, 0));
	Object* shape[100] = { &wheel_00, &wheel_10,&bottom_0, &bottom_1, &face_1,&face_2,&connect_1,&connect_2,&face_3,&face_21,&cross_2,&cross_1,&face_22,&face_23 };

    switch (message)
    {
    case WM_COMMAND:
        {
            int wmId = LOWORD(wParam);
           
            switch (wmId)
            {
			case ID_SHOW:
			{
				for (int i = 0; i < 14; i++)
				{
					shape[i]->show(hWnd, rect);
				}
			}
			break;
			case ID_HIDE:
			{
				for (int i = 0; i < 14; i++)
				{
					shape[i]->hide(hWnd, rect);
				}
			}
			break;
			case ID_MOVE:
			{

				for (int i = 0; i < 14; i++)
				{
					shape[i]->move(hWnd, rect);
				}
			}
			break;
            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
        {
            PAINTSTRUCT ps;
            HDC hdc = BeginPaint(hWnd, &ps);
			GetClientRect(hWnd, &rect);
			lb.lbColor = RGB(255, 255, 255);
			lb.lbStyle = BS_SOLID;
			hBrush = CreateBrushIndirect(&lb);
			holdBrush = (HBRUSH)(SelectObject(hdc, hBrush));
			FloodFill(hdc, 0, 0, RGB(0, 0, 0));
			DeleteObject(SelectObject(hdc, holdBrush));
			DeleteObject(SelectObject(hdc, hBrush));

			for (int i = 0; i < 14; i++)
			{
				shape[i]->drawPicture(hdc);
			}
            EndPaint(hWnd, &ps);
        }
        break;
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

// Message handler for about box.
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}
