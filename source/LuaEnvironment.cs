// LuaEnvironment
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MoonSharp.Interpreter;
using UnityEngine;

public class LuaEnvironment : Singleton<LuaEnvironment>
{
	private bool OEGKPMHIJGF = true;

	private Script LOKOJMIKEEL;

	private Stack<MoonSharp.Interpreter.Coroutine> ICOMJMLACPH;

	private GameState CCNDFDNOFDO;

	private string CIGLJOGKLFA;

	private string OMOCDFBLLPC;

	private readonly string LAKLDHDHLDL = "local CheckCondition = function()";

	private readonly string BIAPMBPJPHE = "end" + Environment.NewLine + "return CheckCondition()";

	private FinishedMapInfo DKGEKMEAJDN;

	private GameEventInfo JIMECEDODAF;

	[CompilerGenerated]
	private static Action<string> BOGJGOAMCHK;

	[CompilerGenerated]
	private static Action<string> BDPNFNJNEFM;

	[CompilerGenerated]
	private static Action MJKNAFJKDMG;

	[CompilerGenerated]
	private static Action JENGHDFDLII;

	[CompilerGenerated]
	private static Action<string> LNIJKGECNME;

	public bool Finished => OEGKPMHIJGF;

	public GameState LuaGameState => CCNDFDNOFDO;

	public FinishedMapInfo FMI
	{
		get
		{
			return DKGEKMEAJDN;
		}
		set
		{
			DKGEKMEAJDN = value;
		}
	}

	public GameEventInfo GEI
	{
		get
		{
			return JIMECEDODAF;
		}
		set
		{
			JIMECEDODAF = value;
		}
	}

	public static void MEADJHBJPKN()
	{
		Singleton<SoundManager>.Instance.StopAllSounds();
	}

	public void AdvanceScript()
	{
		if (ICOMJMLACPH.Count > 0)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == CoroutineState.Dead)
				{
					ICOMJMLACPH.Pop();
					OEGKPMHIJGF = true;
				}
				if (dynValue.Type == DataType.Function)
				{
					ICOMJMLACPH.Push(LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
				return;
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				OEGKPMHIJGF = true;
				ICOMJMLACPH.Clear();
				return;
			}
		}
		OEGKPMHIJGF = true;
	}

	public static void EJPOCDJBFFM()
	{
		Singleton<SoundManager>.Instance.StopAllMusic();
	}

	public bool MEJOHGCOFON(string CJKEBFLPKKD)
	{
		return NEJAGJPGFFD(CJKEBFLPKKD);
	}

	public void JMJNCMGFLOA()
	{
		if (ICOMJMLACPH.Count > 0)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == CoroutineState.NotStarted)
				{
					ICOMJMLACPH.Pop();
					OEGKPMHIJGF = false;
				}
				if (dynValue.Type == DataType.Void)
				{
					ICOMJMLACPH.Push(LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
				return;
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				OEGKPMHIJGF = true;
				ICOMJMLACPH.Clear();
				return;
			}
		}
		OEGKPMHIJGF = true;
	}

	public static void FINNINNOCFC()
	{
		Singleton<SoundManager>.Instance.PIMGPPIHJLH();
	}

	public void JHHJNEFJBDA()
	{
		Init();
	}

	[SpecialName]
	public void NMEMLPDIPII(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	public void RunFirstInit()
	{
		Init();
	}

	public void FMGNMIDMJIL()
	{
		if (ICOMJMLACPH.Count > 0)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == CoroutineState.Suspended)
				{
					ICOMJMLACPH.Pop();
					OEGKPMHIJGF = true;
				}
				if (dynValue.Type == DataType.Number)
				{
					ICOMJMLACPH.Push(LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
				return;
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				OEGKPMHIJGF = false;
				ICOMJMLACPH.Clear();
				return;
			}
		}
		OEGKPMHIJGF = true;
	}

	[SpecialName]
	public void KFBGBEKMNKL(FinishedMapInfo DPNHODJHGJL)
	{
		DKGEKMEAJDN = DPNHODJHGJL;
	}

	public static void PlayMusic(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlayMusic((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN), 1f, true, false);
	}

	[SpecialName]
	public void EMBBNNKBPEL(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	[SpecialName]
	public bool BOAODNLJOKI()
	{
		return OEGKPMHIJGF;
	}

	[SpecialName]
	public void MKLHJBNFMJP(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	public static void JBMJPHONHPL()
	{
		Singleton<SoundManager>.Instance.PIMGPPIHJLH();
	}

	public static void BHNCEBDCPFA(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.EMCBGFPHICJ((AudioClip)ResourcesManager.BBDAJIDMBNJ(NGLCFNBJCIN));
	}

	[SpecialName]
	public void BDFPJBGGBOG(FinishedMapInfo DPNHODJHGJL)
	{
		DKGEKMEAJDN = DPNHODJHGJL;
	}

	public bool RunCheckCondionScript(string CJKEBFLPKKD)
	{
		return BCJNNAKCCKH(CJKEBFLPKKD);
	}

	public bool DBCLOJKHBDP(string CJKEBFLPKKD)
	{
		return KOKNDJDFFCF(CJKEBFLPKKD);
	}

	public void DBLNPNDBMNH()
	{
		if (ICOMJMLACPH.Count > 0)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == (CoroutineState)7)
				{
					ICOMJMLACPH.Pop();
					OEGKPMHIJGF = true;
				}
				if (dynValue.Type == DataType.Tuple)
				{
					ICOMJMLACPH.Push(LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
				return;
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				OEGKPMHIJGF = false;
				ICOMJMLACPH.Clear();
				return;
			}
		}
		OEGKPMHIJGF = true;
	}

	private static void BBAICOFPECH(string BDIMLMKEEKO)
	{
		Debug.Log(BDIMLMKEEKO);
	}

	public static void StopSounds()
	{
		Singleton<SoundManager>.Instance.StopAllSounds();
	}

	public static void FPJIGCKMAJA()
	{
		Singleton<SoundManager>.Instance.StopAllSounds();
	}

	public void ODDKKLIDPHL()
	{
		Init();
	}

	public static void PCLHFPFGFCN()
	{
		Singleton<SoundManager>.Instance.StopAllMusic();
	}

	[SpecialName]
	public FinishedMapInfo MBBENLGCION()
	{
		return DKGEKMEAJDN;
	}

	[SpecialName]
	public bool PMCPFKBCPAM()
	{
		return OEGKPMHIJGF;
	}

	[SpecialName]
	public FinishedMapInfo BHJCFDLIGFJ()
	{
		return DKGEKMEAJDN;
	}

	[SpecialName]
	public FinishedMapInfo OJGBBEGELAL()
	{
		return DKGEKMEAJDN;
	}

	[CompilerGenerated]
	private static void HLIPOKKEOHB(string BDIMLMKEEKO)
	{
		Debug.Log(BDIMLMKEEKO);
	}

	[SpecialName]
	public GameState AMIGGKCKDGG()
	{
		return CCNDFDNOFDO;
	}

	[SpecialName]
	public bool MBLJFNJMMNK()
	{
		return OEGKPMHIJGF;
	}

	[SpecialName]
	public GameState DFANBMCJNJC()
	{
		return CCNDFDNOFDO;
	}

	public static void PlaySound(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlaySound((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN));
	}

	private static void CIIOCKILPDM(string BDIMLMKEEKO)
	{
		Debug.Log(BDIMLMKEEKO);
	}

	public void MEADLKPANGO()
	{
		PJILLPKFCPO();
	}

	public static void JHLAMPLEEIP(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.LFGKEAIJAIB((AudioClip)ResourcesManager.MACOLLJOENJ(NGLCFNBJCIN));
	}

	public bool MBPHDIDGGDJ(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("\n" + CPCBPCJLDNC);
	}

	[SpecialName]
	public FinishedMapInfo KCONMDNJNKK()
	{
		return DKGEKMEAJDN;
	}

	[SpecialName]
	public GameState MGIAHIAOCDM()
	{
		return CCNDFDNOFDO;
	}

	public bool AMPMFFNDBMB(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("_ColorRGB" + CPCBPCJLDNC);
	}

	private bool NEJAGJPGFFD(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[4];
			array[1] = LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[2] = NIJLKJIPFCC;
			array[3] = Environment.NewLine;
			array[6] = BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = LOKOJMIKEEL.DoString(code);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	public bool NILOPHNEAIC(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("#failed: " + CPCBPCJLDNC);
	}

	[SpecialName]
	public GameEventInfo EDIJMIINAGB()
	{
		return JIMECEDODAF;
	}

	public void DMJCJLPFFCP()
	{
		if (ICOMJMLACPH.Count > 1)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == CoroutineState.Suspended)
				{
					ICOMJMLACPH.Pop();
					OEGKPMHIJGF = false;
				}
				if (dynValue.Type == DataType.Table)
				{
					ICOMJMLACPH.Push(LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
				return;
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				OEGKPMHIJGF = true;
				ICOMJMLACPH.Clear();
				return;
			}
		}
		OEGKPMHIJGF = true;
	}

	public static void DEOCENIMOED(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PPJKMFAMPFC((AudioClip)ResourcesManager.POBCMIMPNBF(NGLCFNBJCIN), 1405f, false, true);
	}

	[SpecialName]
	public void HCALKDBGOBO(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	[SpecialName]
	public void ODOPELALIDP(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	public static void JGJHABDDPNO(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlayMusic((AudioClip)ResourcesManager.BKKJBPILALK(NGLCFNBJCIN), 755f, true, true);
	}

	private bool KOKNDJDFFCF(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[6];
			array[0] = LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[2] = NIJLKJIPFCC;
			array[2] = Environment.NewLine;
			array[6] = BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = LOKOJMIKEEL.DoString(code);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	public static void GDGFALEKPMD(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlayMusic((AudioClip)ResourcesManager.MJGKEEAOAAD(NGLCFNBJCIN), 110f, true, false);
	}

	public void HJCFIIHBAAL()
	{
		if (ICOMJMLACPH.Count > 0)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == CoroutineState.Main)
				{
					ICOMJMLACPH.Pop();
					OEGKPMHIJGF = false;
				}
				if (dynValue.Type == DataType.Tuple)
				{
					ICOMJMLACPH.Push(LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
				return;
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				OEGKPMHIJGF = true;
				ICOMJMLACPH.Clear();
				return;
			}
		}
		OEGKPMHIJGF = false;
	}

	[SpecialName]
	public void FLGLLOAHJEI(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	public static void LFGKEAIJAIB(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlaySound((AudioClip)ResourcesManager.MJGKEEAOAAD(NGLCFNBJCIN));
	}

	public bool GAFCMDALGPH(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("addNewButton" + CPCBPCJLDNC);
	}

	[SpecialName]
	public GameState DIMBHEHJPFA()
	{
		return CCNDFDNOFDO;
	}

	public void BHPKFFFICKF()
	{
		if (ICOMJMLACPH.Count > 0)
		{
			try
			{
				MoonSharp.Interpreter.Coroutine coroutine = ICOMJMLACPH.Peek();
				DynValue dynValue = coroutine.Resume();
				if (coroutine.State == CoroutineState.NotStarted)
				{
					ICOMJMLACPH.Pop();
					OEGKPMHIJGF = false;
				}
				if (dynValue.Type == DataType.Tuple)
				{
					ICOMJMLACPH.Push(LOKOJMIKEEL.CreateCoroutine(dynValue).Coroutine);
				}
				return;
			}
			catch (ScriptRuntimeException ex)
			{
				Debug.LogError(ex.DecoratedMessage);
				OEGKPMHIJGF = false;
				ICOMJMLACPH.Clear();
				return;
			}
		}
		OEGKPMHIJGF = false;
	}

	public static void FFNFHGGGEMC(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.EMCBGFPHICJ((AudioClip)ResourcesManager.MACOLLJOENJ(NGLCFNBJCIN));
	}

	public static void MLPFAMNLJDH()
	{
		Singleton<SoundManager>.Instance.StopAllMusic();
	}

	public static void ICBCGIEFLMF()
	{
		Singleton<SoundManager>.Instance.LFOGHDKIMCK();
	}

	public void Init()
	{
		Script.DefaultOptions.DebugPrint = delegate(string BDIMLMKEEKO)
		{
			Debug.Log(BDIMLMKEEKO);
		};
		UserData.RegisterAssembly();
		ICOMJMLACPH = new Stack<MoonSharp.Interpreter.Coroutine>();
		LOKOJMIKEEL = new Script(CoreModules.Preset_SoftSandbox);
		LOKOJMIKEEL.Globals["PlaySound"] = new Action<string>(PlaySound);
		LOKOJMIKEEL.Globals["PlayMusic"] = new Action<string>(PlayMusic);
		LOKOJMIKEEL.Globals["StopMusic"] = new Action(StopMusic);
		LOKOJMIKEEL.Globals["StopSounds"] = new Action(StopSounds);
		JIMECEDODAF = new GameEventInfo();
		LOKOJMIKEEL.Globals["event"] = UserData.Create(JIMECEDODAF);
		DKGEKMEAJDN = new FinishedMapInfo();
		LOKOJMIKEEL.Globals["play"] = UserData.Create(DKGEKMEAJDN);
		CCNDFDNOFDO = new GameState();
	}

	public static void StopMusic()
	{
		Singleton<SoundManager>.Instance.StopAllMusic();
	}

	[SpecialName]
	public GameEventInfo PPEBDMBKOBD()
	{
		return JIMECEDODAF;
	}

	public bool CheckMapEventCondition(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("return " + CPCBPCJLDNC);
	}

	public static void IAABNNPALAF(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PPJKMFAMPFC((AudioClip)ResourcesManager.POBCMIMPNBF(NGLCFNBJCIN), 1747f, true, false);
	}

	public bool IAKGIOHHEKN(string CPCBPCJLDNC)
	{
		return LEEBBBPDEKN("Coord" + CPCBPCJLDNC);
	}

	public bool ENBEECGHGLO(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("_ScreenResolution" + CPCBPCJLDNC);
	}

	public void IONAABPMNFB()
	{
		Init();
	}

	public bool CheckFinishedMapCondition(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("return " + CPCBPCJLDNC);
	}

	public void PJILLPKFCPO()
	{
		Script.DefaultOptions.DebugPrint = delegate(string BDIMLMKEEKO)
		{
			Debug.Log(BDIMLMKEEKO);
		};
		UserData.RegisterAssembly();
		ICOMJMLACPH = new Stack<MoonSharp.Interpreter.Coroutine>();
		LOKOJMIKEEL = new Script(CoreModules.GlobalConsts | CoreModules.TableIterators | CoreModules.LoadMethods | CoreModules.Table | CoreModules.ErrorHandling);
		LOKOJMIKEEL.Globals["{}"] = new Action<string>(FFNFHGGGEMC);
		LOKOJMIKEEL.Globals["_AdaptationSpeed"] = new Action<string>(JGJHABDDPNO);
		LOKOJMIKEEL.Globals["No player left to ask"] = new Action(AFKHDLNPAIE);
		LOKOJMIKEEL.Globals[" base map(s)"] = new Action(FPJIGCKMAJA);
		JIMECEDODAF = new GameEventInfo();
		LOKOJMIKEEL.Globals["BadgeImage"] = UserData.Create(JIMECEDODAF);
		DKGEKMEAJDN = new FinishedMapInfo();
		LOKOJMIKEEL.Globals["SupportLogger "] = UserData.Create(DKGEKMEAJDN);
		CCNDFDNOFDO = new GameState();
	}

	public void DLMPKCLPMGK()
	{
		Init();
	}

	public bool GEEDHEPEHCJ(string CPCBPCJLDNC)
	{
		return LEEBBBPDEKN("shader.crispwinter" + CPCBPCJLDNC);
	}

	[SpecialName]
	public GameEventInfo NINFNGEJCGD()
	{
		return JIMECEDODAF;
	}

	public static void IAPENBFADGK()
	{
		Singleton<SoundManager>.Instance.LFOGHDKIMCK();
	}

	private bool IDKJAIPJOBP(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[4];
			array[1] = LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[2] = NIJLKJIPFCC;
			array[8] = Environment.NewLine;
			array[4] = BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = LOKOJMIKEEL.DoString(code);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	[SpecialName]
	public GameEventInfo DDGJFHBJMPK()
	{
		return JIMECEDODAF;
	}

	public static void ABDPLHJCHAH()
	{
		Singleton<SoundManager>.Instance.LFOGHDKIMCK();
	}

	private bool BCJNNAKCCKH(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string code = LAKLDHDHLDL + Environment.NewLine + NIJLKJIPFCC + Environment.NewLine + BIAPMBPJPHE;
			dynValue = LOKOJMIKEEL.DoString(code);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	public bool ECPADLAOKNA(string CJKEBFLPKKD)
	{
		return BCJNNAKCCKH(CJKEBFLPKKD);
	}

	public void MFCPJPOMGFN()
	{
		PJILLPKFCPO();
	}

	[SpecialName]
	public GameState JMFPEBPBJKF()
	{
		return CCNDFDNOFDO;
	}

	[SpecialName]
	public void IKCGFMHHELO(FinishedMapInfo DPNHODJHGJL)
	{
		DKGEKMEAJDN = DPNHODJHGJL;
	}

	private bool LEEBBBPDEKN(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[0];
			array[0] = LAKLDHDHLDL;
			array[0] = Environment.NewLine;
			array[1] = NIJLKJIPFCC;
			array[1] = Environment.NewLine;
			array[2] = BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = LOKOJMIKEEL.DoString(code);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	public static void AFKHDLNPAIE()
	{
		Singleton<SoundManager>.Instance.PIMGPPIHJLH();
	}

	[SpecialName]
	public bool AOJJGFEAHIJ()
	{
		return OEGKPMHIJGF;
	}

	public static void JFALLLNEFDO(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlayMusic((AudioClip)ResourcesManager.MJGKEEAOAAD(NGLCFNBJCIN), 234f, true, true);
	}

	public bool ELHAOOBHJEB(string CJKEBFLPKKD)
	{
		return IDKJAIPJOBP(CJKEBFLPKKD);
	}

	public bool JOOABEOBABF(string CPCBPCJLDNC)
	{
		return IDKJAIPJOBP("menuthemes" + CPCBPCJLDNC);
	}

	public void BMHPOFKMIJJ()
	{
		Init();
	}

	public static void KHHNECCNAMF(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.KHHNECCNAMF((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN), 412f, true, false);
	}

	[SpecialName]
	public GameEventInfo EKPOOHDFOBN()
	{
		return JIMECEDODAF;
	}
}
