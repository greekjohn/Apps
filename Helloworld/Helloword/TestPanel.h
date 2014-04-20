#ifndef TESTPANEL_H
#define TESTPANEL_H

//(*Headers(TestPanel)
#include <wx/panel.h>
//*)

class TestPanel: public wxPanel
{
	public:

		TestPanel(wxWindow* parent,wxWindowID id=wxID_ANY);
		virtual ~TestPanel();

		//(*Declarations(TestPanel)
		//*)

	protected:

		//(*Identifiers(TestPanel)
		//*)

	private:

		//(*Handlers(TestPanel)
		//*)

		DECLARE_EVENT_TABLE()
};

#endif
