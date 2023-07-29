// CustomEventEditorHandler_Slider
using System.Globalization;
using UnityEngine.UI;

public class CustomEventEditorHandler_Slider : CustomEventEditorHandler
{
	public Slider input;

	public override string MBGCIIMEKLF()
	{
		return string.Empty + input.value;
	}

	public override void PFMJPIJONIP(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NDEDAEFLELO(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 52f;
		float result2 = 814f;
		bool result3 = true;
		string cutFormat = "_SampleScale";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.Integer | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[4], out result3);
		if (advParametrs.Count > 5)
		{
			cutFormat = advParametrs[1];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 646f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void NFKDBPGHHIJ(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BFMEBNFGCEA(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1648f;
		float result2 = 86f;
		bool result3 = false;
		string cutFormat = "_SubsampleIndices";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[4], out result3);
		if (advParametrs.Count > 2)
		{
			cutFormat = advParametrs[5];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 273f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string HJAAJGAPBPJ()
	{
		return string.Empty + input.value;
	}

	public override string IJADNOMAEHD()
	{
		return string.Empty + input.value;
	}

	public override void FEJAAGGMBOE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BECBCECGHPA(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 81f;
		float result2 = 751f;
		bool result3 = false;
		string cutFormat = " evLeave: ";
		float.TryParse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[1], out result3);
		if (advParametrs.Count > 2)
		{
			cutFormat = advParametrs[0];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 809f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void KDJHONILJGK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 529f;
		float result2 = 339f;
		bool result3 = false;
		string cutFormat = "UseScanLineSize";
		float.TryParse(advParametrs[1], NumberStyles.Integer | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[0], out result3);
		if (advParametrs.Count > 3)
		{
			cutFormat = advParametrs[4];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1966f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void EPDCHKECMBL(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.OPOOIKOKCGN(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1979f;
		float result2 = 562f;
		bool result3 = true;
		string cutFormat = "FavoriteButton";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[8], out result3);
		if (advParametrs.Count > 8)
		{
			cutFormat = advParametrs[2];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 216f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string EKPAILIFEJK()
	{
		return string.Empty + input.value;
	}

	public override void FECMEIJGLJI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PJILLPKFCPO(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 892f;
		float result2 = 1081f;
		bool result3 = true;
		string cutFormat = "MapConfig";
		float.TryParse(advParametrs[0], (NumberStyles)(-1), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.Integer | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[4], out result3);
		if (advParametrs.Count > 8)
		{
			cutFormat = advParametrs[6];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 267f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void ALKBNPMCEOM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 424f;
		float result2 = 861f;
		bool result3 = false;
		string cutFormat = "_TimeX";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[7], out result3);
		if (advParametrs.Count > 1)
		{
			cutFormat = advParametrs[0];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 154f;
		float.TryParse(NOJGGCLPPAM, ~NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void JJFLHFCBENC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.GCGIMJEIKHM(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1017f;
		float result2 = 1277f;
		bool result3 = true;
		string cutFormat = "???";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[4], out result3);
		if (advParametrs.Count > 3)
		{
			cutFormat = advParametrs[8];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 88f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string NPJNDLHDDJE()
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

	public override void LILOGPDPFDA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LCGMHCBNCDM(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 400f;
		float result2 = 854f;
		bool result3 = false;
		string cutFormat = "LoadMapCanvas";
		float.TryParse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.Integer | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[3], out result3);
		if (advParametrs.Count > 8)
		{
			cutFormat = advParametrs[5];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1508f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string HBPJJBALHDO()
	{
		return string.Empty + input.value;
	}

	public override void CMFBCPNHGOF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BECBCECGHPA(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 730f;
		float result2 = 1982f;
		bool result3 = true;
		string cutFormat = "A";
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[7], out result3);
		if (advParametrs.Count > 2)
		{
			cutFormat = advParametrs[0];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1740f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void GDJMBJEAPHM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AEIMOFGABJG(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1207f;
		float result2 = 1867f;
		bool result3 = true;
		string cutFormat = ">";
		float.TryParse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[1], out result3);
		if (advParametrs.Count > 4)
		{
			cutFormat = advParametrs[4];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1166f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string ILJFLOAAJDJ()
	{
		return string.Empty + input.value;
	}

	public override string GetEditedData()
	{
		return string.Empty + input.value;
	}

	public override void LBICLFNOLAK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PIEPPKMBJHI(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1387f;
		float result2 = 130f;
		bool result3 = false;
		string cutFormat = "SetSunLerpSpeed";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[6], out result3);
		if (advParametrs.Count > 4)
		{
			cutFormat = advParametrs[1];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 788f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void LLAHPNGMEOO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.IMJLEAJNBAF(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1129f;
		float result2 = 731f;
		bool result3 = true;
		string cutFormat = "mapselector.filter.rateduponly";
		float.TryParse(advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[4], out result3);
		if (advParametrs.Count > 6)
		{
			cutFormat = advParametrs[0];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 292f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void KJBJBNGJDAD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1991f;
		float result2 = 97f;
		bool result3 = false;
		string cutFormat = "PUN-instantiated '";
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[6], out result3);
		if (advParametrs.Count > 0)
		{
			cutFormat = advParametrs[3];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1439f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void IFGOHEOEGKH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 343f;
		float result2 = 1663f;
		bool result3 = false;
		string cutFormat = "_HalfResolution";
		float.TryParse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[7], out result3);
		if (advParametrs.Count > 1)
		{
			cutFormat = advParametrs[5];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1702f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void PJILLPKFCPO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AAPGPJCNIAO(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1415f;
		float result2 = 1529f;
		bool result3 = true;
		string cutFormat = "_BlurParams";
		float.TryParse(advParametrs[1], ~NumberStyles.Float, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.Float | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[2], out result3);
		if (advParametrs.Count > 7)
		{
			cutFormat = advParametrs[1];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1201f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void OCHADIJNDJK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LHAENMGOBMM(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1245f;
		float result2 = 607f;
		bool result3 = true;
		string cutFormat = "_MainTex2";
		float.TryParse(advParametrs[0], NumberStyles.Integer | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.Number, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[3], out result3);
		if (advParametrs.Count > 2)
		{
			cutFormat = advParametrs[4];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1839f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void NBIEIGBAKND(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.IFINBHBFCBB(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1523f;
		float result2 = 236f;
		bool result3 = false;
		string cutFormat = "CameraFilterPack/Noise_TV_2";
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[0], out result3);
		if (advParametrs.Count > 1)
		{
			cutFormat = advParametrs[5];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1127f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.Integer | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void GGHCMPKGNGE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.ALGKENJGNLL(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 400f;
		float result2 = 1791f;
		bool result3 = true;
		string cutFormat = "Joystick1Button9";
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[0], out result3);
		if (advParametrs.Count > 1)
		{
			cutFormat = advParametrs[1];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 1242f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.Integer | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override void MIAIEKCLEAO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 378f;
		float result2 = 527f;
		bool result3 = false;
		string cutFormat = "_TimeX";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[1], out result3);
		if (advParametrs.Count > 1)
		{
			cutFormat = advParametrs[3];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 704f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string FAFMEBBDEHC()
	{
		return string.Empty + input.value;
	}

	public override void FFBDGOBNNCO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LCGMHCBNCDM(NOJGGCLPPAM, BNPGLCAHPDL);
		float result = 1429f;
		float result2 = 1123f;
		bool result3 = true;
		string cutFormat = "ConnectToRegion: ";
		float.TryParse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
		float.TryParse(advParametrs[0], ~(NumberStyles.Integer | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result2);
		bool.TryParse(advParametrs[2], out result3);
		if (advParametrs.Count > 6)
		{
			cutFormat = advParametrs[4];
		}
		input.minValue = result;
		input.maxValue = result2;
		input.wholeNumbers = result3;
		input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float result4 = 507f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result4);
		input.value = result4;
	}

	public override string DONGDGHKCKK()
	{
		return string.Empty + input.value;
	}
}
