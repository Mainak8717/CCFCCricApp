using System;
namespace CCFCCricApp
{
	public interface IConfigDummyResp
	{
		string ReadJsonCalendarDetailsLocalFile();
		string ReadJsonPlayerListLocalFile();
		string ReadJsonContactsLocalFile();
		string ReadJsonResultsLocalFile();
		string ReadJsonPastCaptainsLocalFile();
		string ReadJsonGalleryLocalFile();
	}
}
