/***************************************************************
 * Name:      HelloworldMain.h
 * Purpose:   Defines Application Frame
 * Author:    Joh (635253084@qq.com)
 * Created:   2014-04-20
 * Copyright: Joh ()
 * License:
 **************************************************************/

#ifndef HELLOWORLDMAIN_H
#define HELLOWORLDMAIN_H



#include "HelloworldApp.h"



#include "GUIDialog.h"

class HelloworldDialog: public GUIDialog
{
    public:
        HelloworldDialog(wxDialog *dlg);
        ~HelloworldDialog();
    private:
        virtual void OnClose(wxCloseEvent& event);
        virtual void OnQuit(wxCommandEvent& event);
        virtual void OnAbout(wxCommandEvent& event);
};
#endif // HELLOWORLDMAIN_H
