/***************************************************************
 * Name:      FirstAppMain.h
 * Purpose:   Defines Application Frame
 * Author:    Joh (635253084@qq.com)
 * Created:   2014-04-20
 * Copyright: Joh ()
 * License:
 **************************************************************/

#ifndef FIRSTAPPMAIN_H
#define FIRSTAPPMAIN_H



#include "FirstAppApp.h"


#include "GUIFrame.h"

class FirstAppFrame: public GUIFrame
{
    public:
        FirstAppFrame(wxFrame *frame);
        ~FirstAppFrame();
    private:
        virtual void OnClose(wxCloseEvent& event);
        virtual void OnQuit(wxCommandEvent& event);
        virtual void OnAbout(wxCommandEvent& event);
};

#endif // FIRSTAPPMAIN_H
