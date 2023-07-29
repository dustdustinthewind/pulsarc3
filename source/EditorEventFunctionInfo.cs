// EditorEventFunctionInfo
using System.Collections.Generic;

public class EditorEventFunctionInfo
{
	public enum EditorEventParametrType
	{
		InputField,
		Slider,
		Toggle,
		ArcSelector
	}

	public enum EditorEventType
	{
		Arcs,
		Storyboard
	}

	public class EditorEventParametr
	{
		public string name;

		public EditorEventParametrType editor;

		public string description;

		public string data;

		public EditorEventParametr(string EBEHBBDKDFJ, EditorEventParametrType EBCIFDLBHJJ, string ADLFGFFKELL, string NOJGGCLPPAM = null)
		{
			name = EBEHBBDKDFJ;
			editor = EBCIFDLBHJJ;
			description = ADLFGFFKELL;
			data = NOJGGCLPPAM;
		}
	}

	public List<EditorEventParametr> parameters;

	public string id;

	public string functionName;

	public string functionDescription;

	public int minConfigVersion;

	public int maxConfigVersion = -1;

	public EditorEventType eventType = EditorEventType.Storyboard;

	public EditorEventFunctionInfo(string JMMILEFMACB, string EGIHIANBIGB, List<EditorEventParametr> GNNEKCBOBEG, string GJHPCNJOJFL, int JGCKIJCMMNB = 1, int BAGGOBLDDMK = -1, EditorEventType PPJDFMLJIGN = EditorEventType.Storyboard)
	{
		id = JMMILEFMACB;
		functionName = EGIHIANBIGB;
		parameters = GNNEKCBOBEG;
		functionDescription = GJHPCNJOJFL;
		minConfigVersion = JGCKIJCMMNB;
		maxConfigVersion = BAGGOBLDDMK;
		eventType = PPJDFMLJIGN;
	}
}
