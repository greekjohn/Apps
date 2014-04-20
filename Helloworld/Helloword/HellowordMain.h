/***************************************************************
 * Name:      HellowordMain.h
 * Purpose:   Defines Application Frame
 * Author:    Joh (635253084@qq.com)
 * Created:   2014-04-20
 * Copyright: Joh ()
 * License:
 **************************************************************/

#ifndef HELLOWORDMAIN_H
#define HELLOWORDMAIN_H



#include "HellowordApp.h"



#include "GUIDialog.h"

class HellowordDialog: public GUIDialog
{
    public:
        HellowordDialog(wxDialog *dlg);
        ~HellowordDialog();
    private:
        virtual void OnClose(wxCloseEvent& event);
        virtual void OnQuit(wxCommandEvent& event);
        virtual void OnAbout(wxCommandEvent& event);
};
#endif // HELLOWORDMAIN_H
