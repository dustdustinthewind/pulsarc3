// CustomEventEditorHandler_InputField
using System.Globalization;
using UnityEngine.UI;

public class CustomEventEditorHandler_InputField : CustomEventEditorHandler
{
	public InputField input;

	public override void LCGMHCBNCDM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.IILBHOFEMOE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("UNDISTORT"))
		{
			input.contentType = InputField.ContentType.Name;
			float result = float.Parse(advParametrs[0], NumberStyles.Integer | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string CDDLMMAOLPM()
	{
		return input.text;
	}

	public override void GDJMBJEAPHM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LHAENMGOBMM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Value6"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string KPIMHLOCOHD()
	{
		return input.text;
	}

	public override string PHKMIPMABOA()
	{
		return input.text;
	}

	public override string EPKBPPPMMGA()
	{
		return input.text;
	}

	public override string EAKMDIFDOIK()
	{
		return input.text;
	}

	public override void KDJHONILJGK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EBMNMBNJDMK(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains(" respawn: "))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.Integer | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string LKPFPOKDMHE()
	{
		return input.text;
	}

	public override void FCKLLMEPONC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Visualize"))
		{
			input.contentType = InputField.ContentType.Name;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string HJAAJGAPBPJ()
	{
		return input.text;
	}

	public override string FAFMEBBDEHC()
	{
		return input.text;
	}

	public override string GNGBEIGIOKI()
	{
		return input.text;
	}

	public override void EEKAJCCELHK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.GCGIMJEIKHM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("#ok"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.Integer | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void LILOGPDPFDA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("settings.gamemessagesduration"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void AOEEOKNJDCK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PJILLPKFCPO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("true"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out result);
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

	public override string EGFKNGIBFFD()
	{
		return input.text;
	}

	public override void IFGOHEOEGKH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_DistortionLevel"))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void EJLKPLOEEEP(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PMAGMPCMGPB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("NEW_ACHIEVEMENT_1_"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
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

	public override string OGMDNAALGKK()
	{
		return input.text;
	}

	public override void BKEFJPOHKDE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.GCGIMJEIKHM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("VisionBlur"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void DPOELEBIAOE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("MouseX"))
		{
			input.contentType = InputField.ContentType.Autocorrected;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, (NumberStyles)(-1), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string LJPBCJOKGJL()
	{
		return input.text;
	}

	public override void LBICLFNOLAK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BECBCECGHPA(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("maps."))
		{
			input.contentType = InputField.ContentType.EmailAddress;
			float result = float.Parse(advParametrs[0], NumberStyles.None, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string IJADNOMAEHD()
	{
		return input.text;
	}

	public override void EIPPDLDJJGO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains(" isOwnerActive: "))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void IKLAFGHCELK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.JJFLHFCBENC(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory."))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void PJILLPKFCPO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BFMEBNFGCEA(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("#yes"))
		{
			input.contentType = InputField.ContentType.Autocorrected;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void LMHFEBCKPDI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LMHFEBCKPDI(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_TimeX"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
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

	public override string MFDFEBJDFBI()
	{
		return input.text;
	}

	public override string MMNKKFCFDPI()
	{
		return input.text;
	}

	public override void LLAHPNGMEOO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EBMNMBNJDMK(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains(". We have no such PhotonView! Ignored this if you're leaving a room. State: "))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result);
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
		base.LHAENMGOBMM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("MapConfig"))
		{
			input.contentType = InputField.ContentType.Password;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string MHGPJEGKLGF()
	{
		return input.text;
	}

	public override void DDKHMCOOCPA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BFMEBNFGCEA(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("help"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
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
		base.PIEPPKMBJHI(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Ignored PU RPC, cause item is inactive. "))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
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

	public override void IFINBHBFCBB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.OCCJCGEDNEH(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Joystick1Button10"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string KNFDHLOFAFI()
	{
		return input.text;
	}

	public override void KJBJBNGJDAD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PGKFCCIKFPK(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("LostLive"))
		{
			input.contentType = InputField.ContentType.Password;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result);
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

	public override string NHIMLBNJMOO()
	{
		return input.text;
	}

	public override string GNPEIEBDFPB()
	{
		return input.text;
	}

	public override string ILJFLOAAJDJ()
	{
		return input.text;
	}

	public override void EPDCHKECMBL(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_PrefilterOffs"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.Integer | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void NNFJJJLBPKE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EBMNMBNJDMK(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_ScreenResolution"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
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

	public override void LHIEKHPLMFI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AKMLEJJBBNG(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains(" argument(s): "))
		{
			input.contentType = InputField.ContentType.Alphanumeric;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void POGJLIDHDIH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.GCGIMJEIKHM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains(": "))
		{
			input.contentType = InputField.ContentType.Autocorrected;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void LHAENMGOBMM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NKLCNJEIAFB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_Green_R"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
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
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("settings.cameramovements"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
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

	public override string NCKBLEFJJGL()
	{
		return input.text;
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

	public override void FECMEIJGLJI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.IFINBHBFCBB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("skin.hit_perfect"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
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

	public override void PMAGMPCMGPB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FEJAAGGMBOE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("InputField"))
		{
			input.contentType = InputField.ContentType.EmailAddress;
			float result = float.Parse(advParametrs[0], NumberStyles.Float | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
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
		base.PJILLPKFCPO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Texture2"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string IBAOBHIBDPF()
	{
		return input.text;
	}

	public override void CMFBCPNHGOF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains(","))
		{
			input.contentType = InputField.ContentType.EmailAddress;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string AMFEJANGGIN()
	{
		return input.text;
	}

	public override string GetEditedData()
	{
		return input.text;
	}

	public override void OCHADIJNDJK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NDEDAEFLELO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("settings.volume.menu"))
		{
			input.contentType = InputField.ContentType.IntegerNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
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

	public override void CPJHNDOBFOD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FCKLLMEPONC(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("curScn"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
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

	public override string OFJEIDELJJH()
	{
		return input.text;
	}

	public override void LKEPIEEIMAE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.ALGKENJGNLL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("Clear Environment"))
		{
			input.contentType = InputField.ContentType.Name;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.Integer | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string IGDMJNHEMKN()
	{
		return input.text;
	}

	public override void JJFLHFCBENC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FCKLLMEPONC(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("y"))
		{
			input.contentType = InputField.ContentType.Name;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void OCCJCGEDNEH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AAPGPJCNIAO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("EventMenu"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
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
		base.AAPGPJCNIAO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("CameraFilterPack/Blend2Camera_Darken"))
		{
			input.contentType = InputField.ContentType.Pin;
			float result = float.Parse(advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
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

	public override string DONGDGHKCKK()
	{
		return input.text;
	}

	public override string BKNPEBIOFOE()
	{
		return input.text;
	}

	public override void JLMPMMFKJID(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AAPGPJCNIAO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("SetSunEmission"))
		{
			input.contentType = InputField.ContentType.Password;
			float result = float.Parse(advParametrs[1], NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string MBGCIIMEKLF()
	{
		return input.text;
	}

	public override void BKLCHHKOMLD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("time"))
		{
			input.contentType = InputField.ContentType.DecimalNumber;
			float result = float.Parse(advParametrs[0], NumberStyles.Integer | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
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

	public override string ICEKNBOAIOL()
	{
		return input.text;
	}

	public override string FIDINOJKJLH()
	{
		return input.text;
	}

	public override string ADONGBFFCPP()
	{
		return input.text;
	}

	public override string HDAECKJBNCG()
	{
		return input.text;
	}

	public override void FFBDGOBNNCO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FFBDGOBNNCO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("] "))
		{
			input.contentType = InputField.ContentType.Name;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override void NKLCNJEIAFB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.MHPFCAFDMLC(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("w"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out result);
			}
			input.text = string.Empty + result;
		}
		else
		{
			input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	public override string OLBAGEGOEKF()
	{
		return input.text;
	}

	public override void CFNDDGFGKKG(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LHAENMGOBMM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (advParametrs.Contains("_MatrixSize"))
		{
			input.contentType = InputField.ContentType.Standard;
			float result = float.Parse(advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out result);
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
}
