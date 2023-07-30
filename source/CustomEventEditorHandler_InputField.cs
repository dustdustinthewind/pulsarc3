// CustomEventEditorHandler_InputField
using System.Globalization;
using UnityEngine.UI;

public class CustomEventEditorHandler_InputField : CustomEventEditorHandler
{
	public InputField input;

	public override void LMHFEBCKPDI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("d264dbba9c2410771b4ad918903b3f4cd9e276a9"))
		{
			input.contentType = InputField.ContentType.Autocorrected;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string IHJPAILNFDO()
	{
		return input.text;
	}

	public override void CMFBCPNHGOF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_ProjInfo"))
		{
			input.contentType = InputField.ContentType.Name;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void KOKDPAEJECC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Offsets"))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string PKNECGKHPGP()
	{
		return input.text;
	}

	public override string HDAECKJBNCG()
	{
		return input.text;
	}

	public override void LHIEKHPLMFI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("ENABLE_USER_LUT"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void EBMNMBNJDMK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("SUCCESS! Item submitted! :D :D :D"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void IFGOHEOEGKH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Value"))
		{
			input.contentType = InputField.ContentType.Password;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.Integer | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void MIAIEKCLEAO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Value"))
		{
			input.contentType = InputField.ContentType.EmailAddress;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void LLAHPNGMEOO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("#mapalreadyexistupdate"))
		{
			input.contentType = InputField.ContentType.Autocorrected;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string KCJBOIGBADB()
	{
		return input.text;
	}

	public override string LJPBCJOKGJL()
	{
		return input.text;
	}

	public override string HJAAJGAPBPJ()
	{
		return input.text;
	}

	public override string IJADNOMAEHD()
	{
		return input.text;
	}

	public override string NDLGNGFGBEA()
	{
		return input.text;
	}

	public override void FEJAAGGMBOE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_ReflectionBufferSize"))
		{
			input.contentType = InputField.ContentType.Name;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void CAJFKNFJEKC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Intensity"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void LNMKDFDKFPF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("CameraFilterPack/Vision_Blood"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string HHEGFIMAGLG()
	{
		return input.text;
	}

	public override string LFPAIPMKEPG()
	{
		return input.text;
	}

	public override string MBGCIIMEKLF()
	{
		return input.text;
	}

	public override string BNAHAEANICI()
	{
		return input.text;
	}

	public override string EKPAILIFEJK()
	{
		return input.text;
	}

	public override void IFINBHBFCBB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("CameraFilterPack/FX_Hypno"))
		{
			input.contentType = InputField.ContentType.Autocorrected;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string EOKAOJCKGPD()
	{
		return input.text;
	}

	public override string EDFHJNHJEAN()
	{
		return input.text;
	}

	public override string FPBDGKKPPAE()
	{
		return input.text;
	}

	public override string JFLIFMAKPOA()
	{
		return input.text;
	}

	public override void GGHCMPKGNGE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Drop_With_Obj"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string HAAMIOGFPGI()
	{
		return input.text;
	}

	public override string OLBAGEGOEKF()
	{
		return input.text;
	}

	public override void GDJMBJEAPHM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_ScreenResolution"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void GCNKIJDNPMD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("OpCreateRoom()"))
		{
			input.contentType = InputField.ContentType.Autocorrected;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void OCHADIJNDJK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Loading maps"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.Integer | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string BLHJGCCHKGD()
	{
		return input.text;
	}

	public override void KDJHONILJGK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)"))
		{
			input.contentType = InputField.ContentType.EmailAddress;
			float result = float.Parse(advParametrs[1], NumberStyles.Integer | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void Init(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("float"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string OOEGMHJAGFI()
	{
		return input.text;
	}

	public override string AMFEJANGGIN()
	{
		return input.text;
	}

	public override void NKLCNJEIAFB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("#000000"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void KJBJBNGJDAD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Value"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void ALKBNPMCEOM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("\r"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void GINPIKEJGJD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("BitsData"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string MBIDKKGPPIK()
	{
		return input.text;
	}

	public override void EMOCEKPLGBK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("[Up]"))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string OGMDNAALGKK()
	{
		return input.text;
	}

	public override void BKEFJPOHKDE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_TimeX"))
		{
			input.contentType = InputField.ContentType.EmailAddress;
			float result = float.Parse(advParametrs[0], NumberStyles.Integer | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string EGFKNGIBFFD()
	{
		return input.text;
	}

	public override string OFJEIDELJJH()
	{
		return input.text;
	}

	public override void DDKHMCOOCPA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_TexelOffsetScale"))
		{
			input.contentType = InputField.ContentType.Password;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string NHIMLBNJMOO()
	{
		return input.text;
	}

	public override string BKNPEBIOFOE()
	{
		return input.text;
	}

	public override void EIPPDLDJJGO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("%"))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string HBPJJBALHDO()
	{
		return input.text;
	}

	public override void BBICIPNPMLL(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Editor/"))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string MMNKKFCFDPI()
	{
		return input.text;
	}

	public override void FFBDGOBNNCO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("ConfigVersionSlider"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void KMLHFIHIAON(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("SetSpeed"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string ILJFLOAAJDJ()
	{
		return input.text;
	}

	public override void JKHKHOIHLOI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Jit "))
		{
			input.contentType = InputField.ContentType.Password;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.Float | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void ALGKENJGNLL(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Parent object ID. Case-Sensitive"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string NCKBLEFJJGL()
	{
		return input.text;
	}

	public override void LHAENMGOBMM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("DPADHOR"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string GetEditedData()
	{
		return input.text;
	}

	public override string KHBCKLBHKBH()
	{
		return input.text;
	}

	public override void OPKKBMCDOEM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Value5"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void FCKLLMEPONC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Value2"))
		{
			input.contentType = InputField.ContentType.Password;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string KDDBDAAEALD()
	{
		return input.text;
	}

	public override void EOPEMLDJAAO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("SetParticlesGravity"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.Float | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string HDGHDBKDGIB()
	{
		return input.text;
	}

	public override void EPDCHKECMBL(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("skin.hit_perfect"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void JLMPMMFKJID(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Case-Sensitive"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string INHOEPEBFNM()
	{
		return input.text;
	}

	public override string NDDKNHHAEOJ()
	{
		return input.text;
	}

	public override string FJKOLHJNCCG()
	{
		return input.text;
	}

	public override void IKLAFGHCELK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LKEPIEEIMAE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("#accuracy"))
		{
			input.contentType = InputField.ContentType.Password;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void LCKKDMKJJEF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("CameraFilterPack/TV_ARCADE_Fast"))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[1], NumberStyles.Integer | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void NOBNCNJKOLA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Object ID. Case-Sensitive"))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void NBHGPDAKJGF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EPDCHKECMBL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("GlassesColor2"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.Integer | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string NPJNDLHDDJE()
	{
		return input.text;
	}

	public override void CDDHLFNJOGC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FIMJABKECNG(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Subscribe: "))
		{
			input.contentType = InputField.ContentType.EmailAddress;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void CFKJHLOEDFO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NFKDBPGHHIJ(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("maps."))
		{
			input.contentType = InputField.ContentType.Autocorrected;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void NBIEIGBAKND(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.HBKEHHCMMBN(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("player.orangelifering"))
		{
			input.contentType = InputField.ContentType.Name;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void PMAGMPCMGPB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_SizeX"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void LBICLFNOLAK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("attempted to spawn go ("))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}
}
