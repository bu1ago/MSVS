#pragma once

#include "resource.h"
#include "stdafx.h"

const int move_val = 20;

class Object 
{
protected:
	int xCenter;
	int yCenter;

	COLORREF ShowColor; 
	COLORREF HideColor; 
public:
	Object(int x, int y)
	{
		xCenter = x;
		yCenter = y;
	}
	void move(HWND hWnd, RECT rect)
	{
		xCenter = xCenter + move_val;
		InvalidateRect(hWnd, &rect, TRUE);

	}
	void hide(HWND hWnd, RECT rect)
	{
		ShowColor = COLORREF(RGB(255, 255,255));
		InvalidateRect(hWnd, &rect, TRUE);
	}
	void show(HWND hWnd, RECT rect)
	{
		ShowColor = HideColor;
		InvalidateRect(hWnd, &rect, TRUE);
	}

	virtual void drawPicture(HDC hdc) = 0;
};

class CIRCLE :public Object
{
	int width;
	int height;
public:

	CIRCLE(int x = 0, int y = 0, int h = 0, int w = 0, int Col = RGB(0, 0, 0)) :Object(x, y)
	{
		xCenter = x;
		yCenter = y;
		height = h;
		width = w;
		HideColor = Col;
		ShowColor = Col;
	}
	void drawPicture(HDC hdc)
	{
		HPEN hPen = CreatePen(PS_SOLID, 5, ShowColor);
		DeleteObject(SelectObject(hdc, hPen));
		
		Ellipse(hdc,
			xCenter - width / 2, yCenter,
			xCenter + width / 2, yCenter + height * 3 / 4
		);
		DeleteObject(SelectObject(hdc, hPen));
	}
};
class  LINE :public Object
{
	int width;
	int height;

public:
	LINE(int x = 0, int y = 0, int h = 0, int w = 0, int Col = RGB(0, 0, 0)) :Object(x, y)
	{
		xCenter = x;
		yCenter = y;
		height = h;
		width = w;
		HideColor = Col;
		ShowColor = Col;
	}
	void drawPicture(HDC hdc)
	{
		HPEN hPen = CreatePen(PS_SOLID, 5, ShowColor);
		HPEN holdPen = (HPEN)SelectObject(hdc, hPen);

		MoveToEx(hdc, xCenter, yCenter, NULL);
		LineTo(hdc, xCenter + width, yCenter + height);

		DeleteObject(SelectObject(hdc, holdPen));
		DeleteObject(SelectObject(hdc, hPen));
	};
};