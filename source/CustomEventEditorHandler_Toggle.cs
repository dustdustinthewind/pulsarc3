// CustomEventEditorHandler_Toggle
using UnityEngine.UI;

public class CustomEventEditorHandler_Toggle : CustomEventEditorHandler
{
	public Toggle input;

	public override string OPDPGIGHIKC()
	{
		return string.Empty + input.isOn;
	}

	public override string PBLPGILLGDI()
	{
		return string.Empty + input.isOn;
	}

	public override string EKPAILIFEJK()
	{
		return string.Empty + input.isOn;
	}

	public override void LBICLFNOLAK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		bool result = true;
		bool.TryParse(NOJGGCLPPAM, out result);
		input.isOn = result;
		if (advParametrs.Count > 0)
		{
			GetComponentInChildren<Text>().text = advParametrs[0];
		}
	}

	public override string NPJNDLHDDJE()
	{
		return string.Empty + input.isOn;
	}

	public override void ALKBNPMCEOM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		bool result = true;
		bool.TryParse(NOJGGCLPPAM, out result);
		input.isOn = result;
		if (advParametrs.Count > 0)
		{
			GetComponentInChildren<Text>().text = advParametrs[0];
		}
	}

	public override string GetEditedData()
	{
		return string.Empty + input.isOn;
	}

	public override string NDLGNGFGBEA()
	{
		return string.Empty + input.isOn;
	}

	public override string ILJFLOAAJDJ()
	{
		return string.Empty + input.isOn;
	}

	public override string ACOMLDKGJJJ()
	{
		return string.Empty + input.isOn;
	}

	public override string DENBLPMAKAL()
	{
		return string.Empty + input.isOn;
	}

	public override string ICAKAMDKEJP()
	{
		return string.Empty + input.isOn;
	}

	public override void Init(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		bool result = false;
		bool.TryParse(NOJGGCLPPAM, out result);
		input.isOn = result;
		if (advParametrs.Count > 0)
		{
			GetComponentInChildren<Text>().text = advParametrs[0];
		}
	}

	public override void FFBDGOBNNCO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		bool result = false;
		bool.TryParse(NOJGGCLPPAM, out result);
		input.isOn = result;
		if (advParametrs.Count > 1)
		{
			GetComponentInChildren<Text>().text = advParametrs[1];
		}
	}

	public override void NFKDBPGHHIJ(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		bool result = false;
		bool.TryParse(NOJGGCLPPAM, out result);
		input.isOn = result;
		if (advParametrs.Count > 1)
		{
			GetComponentInChildren<Text>().text = advParametrs[1];
		}
	}

	public override void HBKEHHCMMBN(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		bool result = true;
		bool.TryParse(NOJGGCLPPAM, out result);
		input.isOn = result;
		if (advParametrs.Count > 1)
		{
			GetComponentInChildren<Text>().text = advParametrs[0];
		}
	}

	public override void OCHADIJNDJK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		bool result = true;
		bool.TryParse(NOJGGCLPPAM, out result);
		input.isOn = result;
		if (advParametrs.Count > 0)
		{
			GetComponentInChildren<Text>().text = advParametrs[0];
		}
	}

	public override void PFMJPIJONIP(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		bool result = false;
		bool.TryParse(NOJGGCLPPAM, out result);
		input.isOn = result;
		if (advParametrs.Count > 0)
		{
			GetComponentInChildren<Text>().text = advParametrs[1];
		}
	}
}
