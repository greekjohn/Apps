/***************************************************************
 * Name:      HelloworldMain.cpp
 * Purpose:   Code for Application Frame
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

#include "HelloworldMain.h"

//helper functions
enum wxbuildinfoformat {
    short_f, long_f };

wxString wxbuildinfo(wxbuildinfoformat format)
{
    wxString wxbuild(wxVERSION_STRING);

    if (format == long_f )
    {
#if defined(__WXMSW__)
        wxbuild << _T("-Windows");
#elif defined(__WXMAC__)
        wxbuild << _T("-Mac");
#elif defined(__UNIX__)
        wxbuild << _T("-Linux");
#endif

#if wxUSE_UNICODE
        wxbuild << _T("-Unicode build");
#else
        wxbuild << _T("-ANSI build");
#endif // wxUSE_UNICODE
    }

    return wxbuild;
}



HelloworldDialog::HelloworldDialog(wxDialog *dlg)
    : GUIDialog(dlg)
{
}

HelloworldDialog::~HelloworldDialog()
{
}

void HelloworldDialog::OnClose(wxCloseEvent &event)
{
    Destroy();
}

void HelloworldDialog::OnQuit(wxCommandEvent &event)
{
    Destroy();
}

void HelloworldDialog::OnAbout(wxCommandEvent &event)
{
    wxString msg = wxbuildinfo(long_f);
    wxMessageBox(msg, _("Welcome to..."));
}
