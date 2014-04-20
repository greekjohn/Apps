/***************************************************************
 * Name:      FirstAppApp.cpp
 * Purpose:   Code for Application Class
 * Author:    Joh (635253084@qq.com)
 * Created:   2014-04-20
 * Copyright: Joh ()
 * License:
 **************************************************************/

#ifdef WX_PRECOMP
#include "wx_pch.h"
#endif

#ifdef __BORLANDC__
#pragma hdrstop
#endif //__BORLANDC__

#include "FirstAppApp.h"
#include "FirstAppMain.h"

IMPLEMENT_APP(FirstAppApp);

bool FirstAppApp::OnInit()
{
    FirstAppFrame* frame = new FirstAppFrame(0L);
    frame->SetIcon(wxICON(aaaa)); // To Set App Icon
    frame->Show();
    
    return true;
}
