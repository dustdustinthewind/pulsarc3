// CustomEventEditorHandler_Slider
using System.Globalization;
using UnityEngine.UI;

public class CustomEventEditorHandler_Slider : CustomEventEditorHandler
{
	public Slider input;

	public override void GCNKIJDNPMD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 949f;
		float result2 = 1603f;
		bool result3 = true;
		string cutFormat = "_Vignette_Alpha";
		float.TryParse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[1], out result3);
		if (advParametrs.Count > 7)
		{
			cutFormat = advParametrs[4];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1605f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void EOPEMLDJAAO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1489f;
		float result2 = 1836f;
		bool result3 = false;
		string cutFormat = "ItemsCountText";
		float.TryParse(advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[7], out result3);
		if (advParametrs.Count > 0)
		{
			cutFormat = advParametrs[4];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1832f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string NGFPEIOEDJM()
	{
		return string.Empty + input.value;
	}

	public override void GDJMBJEAPHM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 478f;
		float result2 = 225f;
		bool result3 = true;
		string cutFormat = "CameraFilterPack/Colors_Brightness";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[8], out result3);
		if (advParametrs.Count > 1)
		{
			cutFormat = advParametrs[6];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1337f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void MIAIEKCLEAO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1926f;
		float result2 = 1770f;
		bool result3 = true;
		string cutFormat = "_TimeX";
		float.TryParse(advParametrs[1], NumberStyles.Float | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[8], out result3);
		if (advParametrs.Count > 6)
		{
			cutFormat = advParametrs[5];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1375f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void OCHADIJNDJK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 90f;
		float result2 = 1064f;
		bool result3 = true;
		string cutFormat = "BestScoreText";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[2], out result3);
		if (advParametrs.Count > 1)
		{
			cutFormat = advParametrs[0];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 99f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string OLDDPMNNCLG()
	{
		return string.Empty + input.value;
	}

	public override void FIMJABKECNG(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 881f;
		float result2 = 451f;
		bool result3 = true;
		string cutFormat = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
		float.TryParse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[7], out result3);
		if (advParametrs.Count > 7)
		{
			cutFormat = advParametrs[5];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1931f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string OLBAGEGOEKF()
	{
		return string.Empty + input.value;
	}

	public override void Init(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 0f;
		float result2 = 1f;
		bool result3 = false;
		string cutFormat = "0.00";
		float.TryParse(advParametrs[0], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[2], out result3);
		if (advParametrs.Count > 3)
		{
			cutFormat = advParametrs[3];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 0f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string HDCJGCHLDJF()
	{
		return string.Empty + input.value;
	}

	public override void IFINBHBFCBB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1204f;
		float result2 = 1741f;
		bool result3 = false;
		string cutFormat = "(\\[ */ *quote *\\])";
		float.TryParse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[6], out result3);
		if (advParametrs.Count > 6)
		{
			cutFormat = advParametrs[7];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 767f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.Number | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string LFPAIPMKEPG()
	{
		return string.Empty + input.value;
	}

	public override void DPOELEBIAOE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1500f;
		float result2 = 1148f;
		bool result3 = false;
		string cutFormat = "EventTimeInputField";
		float.TryParse(advParametrs[1], ~NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[5], out result3);
		if (advParametrs.Count > 1)
		{
			cutFormat = advParametrs[1];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1708f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string NDLGNGFGBEA()
	{
		return string.Empty + input.value;
	}

	public override void LKEPIEEIMAE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 850f;
		float result2 = 884f;
		bool result3 = false;
		string cutFormat = "Loss ";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], ~NumberStyles.AllowLeadingSign, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[1], out result3);
		if (advParametrs.Count > 0)
		{
			cutFormat = advParametrs[2];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1836f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string EAKMDIFDOIK()
	{
		return string.Empty + input.value;
	}

	public override string BLHJGCCHKGD()
	{
		return string.Empty + input.value;
	}

	public override string ACOMLDKGJJJ()
	{
		return string.Empty + input.value;
	}

	public override string GNPEIEBDFPB()
	{
		return string.Empty + input.value;
	}

	public override string ICEKNBOAIOL()
	{
		return string.Empty + input.value;
	}

	public override string DJHKKABLENE()
	{
		return string.Empty + input.value;
	}

	public override void MDPJHKECLOF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 190f;
		float result2 = 840f;
		bool result3 = false;
		string cutFormat = ".wav";
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[6], out result3);
		if (advParametrs.Count > 6)
		{
			cutFormat = advParametrs[5];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1820f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string EOKAOJCKGPD()
	{
		return string.Empty + input.value;
	}

	public override string HJAAJGAPBPJ()
	{
		return string.Empty + input.value;
	}

	public override void PAFMNAIDAFH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1231f;
		float result2 = 1792f;
		bool result3 = true;
		string cutFormat = "Error0";
		float.TryParse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[7], out result3);
		if (advParametrs.Count > 2)
		{
			cutFormat = advParametrs[8];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1563f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string NDDKNHHAEOJ()
	{
		return string.Empty + input.value;
	}

	public override string FIDINOJKJLH()
	{
		return string.Empty + input.value;
	}

	public override string BJJHICBDIJJ()
	{
		return string.Empty + input.value;
	}

	public override string EDFHJNHJEAN()
	{
		return string.Empty + input.value;
	}

	public override string GNGBEIGIOKI()
	{
		return string.Empty + input.value;
	}

	public override void IFGOHEOEGKH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 925f;
		float result2 = 158f;
		bool result3 = true;
		string cutFormat = "menu.selectedplaymode";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[3], out result3);
		if (advParametrs.Count > 0)
		{
			cutFormat = advParametrs[6];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 610f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string PBLPGILLGDI()
	{
		return string.Empty + input.value;
	}

	public override string IJADNOMAEHD()
	{
		return string.Empty + input.value;
	}

	public override string KNFDHLOFAFI()
	{
		return string.Empty + input.value;
	}

	public override string ILJFLOAAJDJ()
	{
		return string.Empty + input.value;
	}

	public override string FPBDGKKPPAE()
	{
		return string.Empty + input.value;
	}

	public override string MBGCIIMEKLF()
	{
		return string.Empty + input.value;
	}

	public override string HBPJJBALHDO()
	{
		return string.Empty + input.value;
	}

	public override void ALKBNPMCEOM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 941f;
		float result2 = 1591f;
		bool result3 = true;
		string cutFormat = "public";
		float.TryParse(advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[8], out result3);
		if (advParametrs.Count > 0)
		{
			cutFormat = advParametrs[7];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 266f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void NOBNCNJKOLA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 549f;
		float result2 = 1432f;
		bool result3 = false;
		string cutFormat = "FileLabel";
		float.TryParse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[3], out result3);
		if (advParametrs.Count > 5)
		{
			cutFormat = advParametrs[4];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 479f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string AOLHFMMCMDE()
	{
		return string.Empty + input.value;
	}

	public override string GetEditedData()
	{
		return string.Empty + input.value;
	}

	public override string FAFMEBBDEHC()
	{
		return string.Empty + input.value;
	}

	public override string NCOPOFANBEG()
	{
		return string.Empty + input.value;
	}

	public override void LLAHPNGMEOO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1885f;
		float result2 = 385f;
		bool result3 = true;
		string cutFormat = "[LevelEditorScene] Print Audio Wave: Done";
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.Integer | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[4], out result3);
		if (advParametrs.Count > 5)
		{
			cutFormat = advParametrs[3];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1037f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void LDKFAGOEDKF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1561f;
		float result2 = 1557f;
		bool result3 = false;
		string cutFormat = "DPADHOR";
		float.TryParse(advParametrs[0], NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[1], out result3);
		if (advParametrs.Count > 2)
		{
			cutFormat = advParametrs[1];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 750f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string NILKMGNEMFO()
	{
		return string.Empty + input.value;
	}

	public override void PFMJPIJONIP(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1936f;
		float result2 = 1322f;
		bool result3 = true;
		string cutFormat = "offsets";
		float.TryParse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.Integer | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[5], out result3);
		if (advParametrs.Count > 5)
		{
			cutFormat = advParametrs[6];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1215f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string OFJEIDELJJH()
	{
		return string.Empty + input.value;
	}
}
