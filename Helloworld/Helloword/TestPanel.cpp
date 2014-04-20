#include "TestPanel.h"

//(*InternalHeaders(TestPanel)
#include <wx/intl.h>
#include <wx/string.h>
//*)

//(*IdInit(TestPanel)
//*)

BEGIN_EVENT_TABLE(TestPanel,wxPanel)
	//(*EventTable(TestPanel)
	//*)
END_EVENT_TABLE()

TestPanel::TestPanel(wxWindow* parent,wxWindowID id)
{
	//(*Initialize(TestPanel)
	Create(parent, id, wxDefaultPosition, wxDefaultSize, wxTAB_TRAVERSAL, _T("id"));
	//*)
}

TestPanel::~TestPanel()
{
	//(*Destroy(TestPanel)
	//*)
}

