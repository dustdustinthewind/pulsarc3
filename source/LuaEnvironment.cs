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

	public static void PlaySound(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlaySound((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN));
	}

	[SpecialName]
	public GameState BGFLHMPLIHO()
	{
		return CCNDFDNOFDO;
	}

	[CompilerGenerated]
	private static void HLIPOKKEOHB(string BDIMLMKEEKO)
	{
		Debug.Log(BDIMLMKEEKO);
	}

	[SpecialName]
	public void EBFHDLKMOIN(FinishedMapInfo DPNHODJHGJL)
	{
		DKGEKMEAJDN = DPNHODJHGJL;
	}

	public bool DFAIJFMEOAC(string CPCBPCJLDNC)
	{
		return MCDKGOLIBAP("SetSatelliteEmission" + CPCBPCJLDNC);
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

	public static void KIMDPEAEODG()
	{
		Singleton<SoundManager>.Instance.StopAllMusic();
	}

	public static void NCCIEIENFMC(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlayMusic((AudioClip)ResourcesManager.KLNILBOBLIL(NGLCFNBJCIN), 1758f, false, false);
	}

	private bool MCDKGOLIBAP(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[1];
			array[0] = LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[8] = NIJLKJIPFCC;
			array[2] = Environment.NewLine;
			array[7] = BIAPMBPJPHE;
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
	public void JDHJHEDPFPH(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	public void RunFirstInit()
	{
		Init();
	}

	public void AOBLOMMDBFB()
	{
		IFGOHEOEGKH();
	}

	public static void MCMEJKMCEMK()
	{
		Singleton<SoundManager>.Instance.GEHIKFMPALA();
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

	public static void MGAFPLHNCIO(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlaySound((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN));
	}

	[SpecialName]
	public GameEventInfo PEJJMEIFHDK()
	{
		return JIMECEDODAF;
	}

	public bool CheckFinishedMapCondition(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("return " + CPCBPCJLDNC);
	}

	[SpecialName]
	public bool PFOGPEBKMPE()
	{
		return OEGKPMHIJGF;
	}

	public void IFGOHEOEGKH()
	{
		Script.DefaultOptions.DebugPrint = IOCIMOEILGA;
		UserData.RegisterAssembly(null, true);
		ICOMJMLACPH = new Stack<MoonSharp.Interpreter.Coroutine>();
		LOKOJMIKEEL = new Script(~(CoreModules.Basic | CoreModules.GlobalConsts | CoreModules.TableIterators | CoreModules.Table));
		LOKOJMIKEEL.Globals["_ScreenResolution"] = new Action<string>(MLDOGKCDPEL);
		LOKOJMIKEEL.Globals["_Red_G"] = new Action<string>(PlayMusic);
		LOKOJMIKEEL.Globals[" - "] = new Action(StopMusic);
		LOKOJMIKEEL.Globals["_BorderColor"] = new Action(LNCGFCJAENP);
		JIMECEDODAF = new GameEventInfo();
		LOKOJMIKEEL.Globals["_Value"] = UserData.Create(JIMECEDODAF);
		DKGEKMEAJDN = new FinishedMapInfo();
		LOKOJMIKEEL.Globals["CameraFilterPack/Light_Water"] = UserData.Create(DKGEKMEAJDN);
		CCNDFDNOFDO = new GameState();
	}

	public static void StopMusic()
	{
		Singleton<SoundManager>.Instance.StopAllMusic();
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

	public void EBIJMBJCPIG()
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

	public bool RunCheckCondionScript(string CJKEBFLPKKD)
	{
		return BCJNNAKCCKH(CJKEBFLPKKD);
	}

	public static void LNCGFCJAENP()
	{
		Singleton<SoundManager>.Instance.PGBLEMNPOIP();
	}

	public static void MLDOGKCDPEL(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.DPNPEKBEPKE((AudioClip)ResourcesManager.OPIGIBCFLHE(NGLCFNBJCIN));
	}

	public static void PlayMusic(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.PlayMusic((AudioClip)ResourcesManager.GetLoadedResource(NGLCFNBJCIN), 1f, true, false);
	}

	public static void StopSounds()
	{
		Singleton<SoundManager>.Instance.StopAllSounds();
	}

	[SpecialName]
	public void GLOGJGHFFII(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	public bool AHKNANJJBJM(string CPCBPCJLDNC)
	{
		return DFHGAEEMHCA("Blues" + CPCBPCJLDNC);
	}

	public void CEBILICFHAN()
	{
		Init();
	}

	public void MCPIGBBEIHD()
	{
		Init();
	}

	private bool BFEOBMCCHIK(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[8];
			array[0] = LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[2] = NIJLKJIPFCC;
			array[1] = Environment.NewLine;
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

	public bool CheckMapEventCondition(string CPCBPCJLDNC)
	{
		return BCJNNAKCCKH("return " + CPCBPCJLDNC);
	}

	public bool BCKENCHNKJB(string CJKEBFLPKKD)
	{
		return MCDKGOLIBAP(CJKEBFLPKKD);
	}

	private bool DFHGAEEMHCA(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[7];
			array[0] = LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[5] = NIJLKJIPFCC;
			array[2] = Environment.NewLine;
			array[7] = BIAPMBPJPHE;
			string code = string.Concat(array);
			dynValue = LOKOJMIKEEL.DoString(code);
		}
		catch (SyntaxErrorException ex)
		{
			Debug.LogError(ex.DecoratedMessage);
		}
		return dynValue.Boolean;
	}

	public static void IJGCPKCFBMA(string NGLCFNBJCIN)
	{
		Singleton<SoundManager>.Instance.HFCDOGPNMCE((AudioClip)ResourcesManager.HIILLNPNNOB(NGLCFNBJCIN), 272f, true, true);
	}

	[SpecialName]
	public void BHFPNAPAFNM(GameEventInfo DPNHODJHGJL)
	{
		JIMECEDODAF = DPNHODJHGJL;
	}

	[SpecialName]
	public GameEventInfo NOCNNNKPEGI()
	{
		return JIMECEDODAF;
	}

	private bool CAMLLJKNLKC(string NIJLKJIPFCC)
	{
		DynValue dynValue = DynValue.Nil;
		try
		{
			string[] array = new string[1];
			array[0] = LAKLDHDHLDL;
			array[1] = Environment.NewLine;
			array[7] = NIJLKJIPFCC;
			array[8] = Environment.NewLine;
			array[0] = BIAPMBPJPHE;
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
	public GameEventInfo KNBBEFDHELF()
	{
		return JIMECEDODAF;
	}

	private static void IOCIMOEILGA(string BDIMLMKEEKO)
	{
		Debug.Log(BDIMLMKEEKO);
	}
}
