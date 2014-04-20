/***************************************************************
 * Name:      HellowordApp.cpp
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

#include "HellowordApp.h"
#include "HellowordMain.h"

IMPLEMENT_APP(HellowordApp);

bool HellowordApp::OnInit()
{
    
    HellowordDialog* dlg = new HellowordDialog(0L);
    dlg->SetIcon(wxICON(aaaa)); // To Set App Icon
    dlg->Show();
    return true;
}
