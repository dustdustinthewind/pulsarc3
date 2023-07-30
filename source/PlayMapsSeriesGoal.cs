// PlayMapsSeriesGoal
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class PlayMapsSeriesGoal : ChallengeGoal
{
	private int MHLPNLMDILP;

	private string CBMKNPLELGP = "true";

	private List<string> ODBKIFAGALM;

	private void ENIKLDCPDPJ(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GCJEPNMMPDK(Singleton<LuaEnvironment>.Instance.MBBENLGCION());
		if (Singleton<LuaEnvironment>.Instance.GEEDHEPEHCJ(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.FPKAOFBFCNG()))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.FPKAOFBFCNG());
			BNPNMCFLDNI(OFIFLHGIMAJ());
		}
	}

	public override void AOKFKNMHHGD()
	{
		base.HBLGNPFJGBF();
		string @string = Singleton<SaveSystem>.Instance.GetString(KOHBJKHPDGK() + "menutheme");
		if (!string.IsNullOrEmpty(@string))
		{
			char[] array = new char[0];
			array[0] = 'ﾨ';
			ODBKIFAGALM = @string.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		AHMNICEJLMF(OFIFLHGIMAJ());
	}

	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetString(PHPLKBPIMIH() + ".completedMaps", string.Join(",", ODBKIFAGALM.ToArray()));
	}

	public override void NAHLBHOLNCG()
	{
		base.HEPLJACPKFO();
		string text = Singleton<SaveSystem>.Instance.FDFHEKDDEID(PHPLKBPIMIH() + "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.");
		if (!string.IsNullOrEmpty(text))
		{
			ODBKIFAGALM = text.Split('\v').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		NHENNCOILPG(CAOJDEFHMAG());
	}

	public override void CHCDBHJILJB()
	{
		base.EMDHDEGLPPF();
		string text = Singleton<SaveSystem>.Instance.FDFHEKDDEID(BGOBKCLKJMD() + "_Val3");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[1] = 'ﾠ';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		BNPNMCFLDNI(OFIFLHGIMAJ());
	}

	public override void Reset()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(PHPLKBPIMIH() + ".completedMaps");
		base.Reset();
	}

	private void HOGJGGGDPDD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = CAOJDEFHMAG();
		}
	}

	public override void LoadProgress()
	{
		base.LoadProgress();
		string @string = Singleton<SaveSystem>.Instance.GetString(PHPLKBPIMIH() + ".completedMaps");
		if (!string.IsNullOrEmpty(@string))
		{
			ODBKIFAGALM = @string.Split(',').ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = CAOJDEFHMAG();
	}

	private void HAHJHHCDBFJ(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.OJGBBEGELAL());
		if (Singleton<LuaEnvironment>.Instance.IAKGIOHHEKN(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.FPKAOFBFCNG()))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.FPKAOFBFCNG());
			JKINKBKCGFP(BINEJBHDMOH());
		}
	}

	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		base.OnCompleted();
	}

	private float EOOBFBPJFKE()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	private float OFIFLHGIMAJ()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void ILOBNHKDGPG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KHMFEHEPGAM(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = 'ﾰ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join(" user's map(s)", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= HAHJHHCDBFJ;
		Singleton<GameManager>.Instance.BKDFHECPBCM(ENIKLDCPDPJ);
		HEPLJACPKFO();
	}

	public override void PGPMPNANPLM()
	{
		base.HOEHJFEELNJ();
		Singleton<SaveSystem>.Instance.ELJPKMDFBML(FJFFJLBABDI() + "_Cible", string.Join("GlassesColor2", ODBKIFAGALM.ToArray()));
	}

	public override void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(',');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join(",", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		Singleton<GameManager>.Instance.OnFinishedMap += HOGJGGGDPDD;
		LoadProgress();
	}

	public override void OIIALMBOFIF()
	{
		base.ABCFDOIKMKH();
		Singleton<SaveSystem>.Instance.SetString(KHILCMNLMOJ() + "CameraFilterPack/Blend2Camera_Saturation", string.Join("/files/editor_manual.pdf", ODBKIFAGALM.ToArray()));
	}

	public override void FGAPIOELJCG()
	{
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM(KHILCMNLMOJ() + "ComboScoreText");
		base.IJHPPIHFFEA();
	}

	public override void NHFICNGICBA()
	{
		base.OMENGFPFDLL();
		Singleton<SaveSystem>.Instance.PGGCEKDPMLL(IKLKPAJBHGB() + "CameraFilterPack_Atmosphere_Rain_FX", string.Join("EventConfigButton", ODBKIFAGALM.ToArray()));
	}

	public override void OOEIABOMFHP(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NOFLEDOPHMO(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = 'ￛ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("IntraSig", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.None);
		CBMKNPLELGP = cBMKNPLELGP;
		ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.IJANEODJFIG(KGGEMDGNLGK);
		Singleton<GameManager>.Instance.OnFinishedMap += KGGEMDGNLGK;
		HEPLJACPKFO();
	}

	private float BINEJBHDMOH()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void JNLJADDKPAI()
	{
		Singleton<GameManager>.Instance.IJANEODJFIG(KGGEMDGNLGK);
		base.AKDBKOIHBND();
	}

	public override void HFFAJNCOJNB()
	{
		Singleton<SaveSystem>.Instance.IOJKJDBACPC(BGOBKCLKJMD() + "GroupNameText");
		base.FAJIDEMHBCF();
	}

	public override void HGICCNCNJDG()
	{
		base.EMDHDEGLPPF();
		string text = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(KHILCMNLMOJ() + "\n");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[0] = 'L';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		JKINKBKCGFP(OFIFLHGIMAJ());
	}

	public override void IMJJCJGAPHP()
	{
		Singleton<GameManager>.Instance.GPEKLFBAAGI(HOGJGGGDPDD);
		base.NHKOCDNCIJB();
	}

	private float CAOJDEFHMAG()
	{
		return (float)ODBKIFAGALM.Count / (float)MHLPNLMDILP;
	}

	public override void GONKPNAAIEE()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(JLGGLIMFAFJ() + "_PositionY");
		base.CJPIGOKLKOA();
	}

	public override void JJJMONDEDJN()
	{
		base.EMDHDEGLPPF();
		string text = Singleton<SaveSystem>.Instance.FDFHEKDDEID(BGOBKCLKJMD() + "<size=24>");
		if (!string.IsNullOrEmpty(text))
		{
			char[] array = new char[0];
			array[1] = '\u001b';
			ODBKIFAGALM = text.Split(array).ToList();
		}
		else
		{
			ODBKIFAGALM = new List<string>();
		}
		BNPNMCFLDNI(EOOBFBPJFKE());
	}

	private void KGGEMDGNLGK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.MBBENLGCION());
		if (Singleton<LuaEnvironment>.Instance.AMPMFFNDBMB(CBMKNPLELGP) && !ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			ODBKIFAGALM.Add(DAGALCAILLN.FPKAOFBFCNG());
			base.GoalProgress = CAOJDEFHMAG();
		}
	}

	public override void BMMJGMKOBJL()
	{
		Singleton<GameManager>.Instance.IJANEODJFIG(HAHJHHCDBFJ);
		base.MBIEFOLFKGJ();
	}
}
