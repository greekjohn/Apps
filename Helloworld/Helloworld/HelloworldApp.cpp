/***************************************************************
 * Name:      HelloworldApp.cpp
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

#include "HelloworldApp.h"
#include "HelloworldMain.h"

IMPLEMENT_APP(HelloworldApp);

bool HelloworldApp::OnInit()
{
    
    HelloworldDialog* dlg = new HelloworldDialog(0L);
    dlg->SetIcon(wxICON(aaaa)); // To Set App Icon
    dlg->Show();
    return true;
}
