// FullMapData
using System;
using System.Collections.Generic;
using System.Globalization;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

[Serializable]
public class FullMapData
{
	public enum MapSource
	{
		Original,
		Editor,
		Workshop
	}

	public Dictionary<string, UnityEngine.Object> resources = new Dictionary<string, UnityEngine.Object>();

	public MapData mapData;

	public ObscuredString workshopId;

	public ulong mapperSteamID;

	public MapSource source;

	public string fullLevelPath = string.Empty;

	public Sprite icon;

	public AudioClip clip;

	public int AKLKLIFHBJP()
	{
		int num = 1;
		string hFEFHOPOLIK = "LastHighScoreText" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_ScreenResolution";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public bool CGIBNFNKNIA()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool EFMNEPDMCHN()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool OBJNELDHNOM()
	{
		bool flag = false;
		string hFEFHOPOLIK = "NO" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_ScreenResolution";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1) != 1 && false;
	}

	public int MGMALOHFDEE()
	{
		int num = 1;
		string hFEFHOPOLIK = "_ScreenResolution" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Value2";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public bool JEIOFADHIDP()
	{
		bool flag = false;
		string hFEFHOPOLIK = "value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "Edited event";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1) != 1 && false;
	}

	public int NBFCBMIPBOO()
	{
		int num = 0;
		string hFEFHOPOLIK = "Internal LUT" + Singleton<MapsSystem>.Instance.GetMapID(this) + ": ";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public bool MOLBDPJCIPL()
	{
		bool flag = false;
		string hFEFHOPOLIK = "Editor/" + Singleton<MapsSystem>.Instance.GetMapID(this) + "BadgeText";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1) != 0 || true;
	}

	public bool EDIINFMLDGN()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int JEOHJLCCMKB()
	{
		int num = 0;
		string hFEFHOPOLIK = "_Value2" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_ExposureAdjustment";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public int GEKFEILHNHD()
	{
		int num = 0;
		string hFEFHOPOLIK = "Sequence contains no elements" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Wavy";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0);
	}

	public bool GDDFCHGLIAE()
	{
		bool flag = true;
		string hFEFHOPOLIK = ".completedMaps" + Singleton<MapsSystem>.Instance.GetMapID(this) + "settings_bindings_";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 0) != 1;
	}

	public bool OJFBLCJNGME()
	{
		bool flag = false;
		string hFEFHOPOLIK = "CameraFilterPack/Blend2Camera_Difference" + Singleton<MapsSystem>.Instance.GetMapID(this) + ": ";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1) != 0 && false;
	}

	public bool CJBKIKCNOKC()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[1] = 'ﾶ';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array2[1]))
					{
						switch (array2[1])
						{
						case "Edited hands count":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[1]) != int.Parse(array2[4]))
							{
								flag = false;
							}
							break;
						case "CameraFilterPack/Vision_Blood":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[1]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[0]) != ((!(array2[8] == " GameServer:")) ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "Connection failed: ":
							if (Singleton<SaveSystem>.Instance.GetString(array2[0]) != array2[5])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[0] == "#close")
					{
						flag = true;
					}
					else
					{
						Debug.Log("challenges." + array2[0] + "?");
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (CBKKILEAMDA())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool ELFPAAFCNAE()
	{
		bool flag = true;
		if (source == MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split('ﾣ');
				if (array.Length == 8)
				{
					if (Singleton<SaveSystem>.Instance.OHIBODCDDKB(array[1]))
					{
						switch (array[1])
						{
						case "original.tutorial":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array[1]) != int.Parse(array[5]))
							{
								flag = true;
							}
							break;
						case ". No ViewIDs are free to use. Max is: ":
							if (Singleton<SaveSystem>.Instance.GetFloat(array[1]) != float.Parse(array[0], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array[0]) != ((array[6] == "_ScreenResolution") ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "https://store.steampowered.com/recommended/recommendgame/":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array[0]) != array[5])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[1] == "_VelTex")
					{
						flag = false;
					}
					else
					{
						Debug.Log("Missing shader in " + array[1] + "settings.shaders");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (IBFKBPHBNHJ())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool isLoaded()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool MPFDFLBLFMN()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[1] = 'Y';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 8)
				{
					if (Singleton<SaveSystem>.Instance.OHIBODCDDKB(array2[1]))
					{
						switch (array2[1])
						{
						case "_MainTex2":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[1]) != int.Parse(array2[6]))
							{
								flag = true;
							}
							break;
						case "_DiffuseColor":
							if (Singleton<SaveSystem>.Instance.HAMBEDDLMAG(array2[0]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_Value2":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[1]) != ((array2[7] == "_Value7") ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "finished":
							if (Singleton<SaveSystem>.Instance.GetString(array2[0]) != array2[7])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "SetParticlesParticleSpeed")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_InternalLutTex" + array2[1] + "|");
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (AFBIKGAODND())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool HBKCOENFINL()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int HCCNODIHMNO()
	{
		int num = 1;
		string hFEFHOPOLIK = "_ScreenResolution" + Singleton<MapsSystem>.Instance.GetMapID(this) + "PossibleMapMaxScoreText";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0);
	}

	public int KPLNDJKFNPG()
	{
		int num = 0;
		string hFEFHOPOLIK = "shader.ghost" + Singleton<MapsSystem>.Instance.GetMapID(this) + "#ok";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 1);
	}

	public bool OMKJMAPFCII()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool IBFKBPHBNHJ()
	{
		bool flag = false;
		string hFEFHOPOLIK = "[#clicktogetreward]" + Singleton<MapsSystem>.Instance.GetMapID(this) + "CameraFilterPack_Atmosphere_Rain_FX";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 0) != 0 || true;
	}

	public int HGFIMAGOPBF()
	{
		int num = 0;
		string hFEFHOPOLIK = "Joystick1Button5" + Singleton<MapsSystem>.Instance.GetMapID(this) + "{0} hours ago";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0);
	}

	public bool FIDJFGDCICN()
	{
		bool flag = true;
		string hFEFHOPOLIK = "_Value3" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Visualize";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 0) != 0 && false;
	}

	public bool IJNLGFINHBL()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public int PDDDGMLCANJ()
	{
		int num = 1;
		string hFEFHOPOLIK = "restrictions\n\n#until: " + Singleton<MapsSystem>.Instance.GetMapID(this) + " to: ";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 1);
	}

	public bool ONPNPCBLDOM()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool POJFNMCAJAC()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool DMMJJIHALHJ()
	{
		bool flag = false;
		if (source == MapSource.Editor)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[0] = '\ufffa';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 4)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[0]))
					{
						switch (array2[1])
						{
						case "The number of objects sent via a PhotonStreamQueue has to be the same each frame":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[1]) != int.Parse(array2[4]))
							{
								flag = false;
							}
							break;
						case "achievements.21.completed.":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[1]) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "mapselector.orderby":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[0]) != ((!(array2[1] == "_Distortion2")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "_Source":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0]) != array2[0])
							{
								flag = true;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[0] == "settings_bindings_sec_")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_SSRMultiplier" + array2[1] + "skin.hit_normal");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (OJFBLCJNGME())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool CJNKBHCDNOL()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool PPDPIPOFCHC()
	{
		bool flag = true;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[0] = 'ﾻ';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 8)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array2[1]))
					{
						switch (array2[1])
						{
						case "curScn":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array2[1]) != int.Parse(array2[2]))
							{
								flag = true;
							}
							break;
						case "_Value3":
							if (Singleton<SaveSystem>.Instance.OOHMHLJADED(array2[0]) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "ls":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[0]) != ((!(array2[3] == "isVisible")) ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array2[0]) != array2[4])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[0] == "EnableRankedNotificationsToggle")
					{
						flag = false;
					}
					else
					{
						Debug.Log("CameraFilterPack/Blend2Camera_Color" + array2[0] + "Joystick1Button2");
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (KLKNPOJIJID())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public FullMapData(MapData CLCBMMEKBBC, string FJDHGDHKNNG, MapSource HLBKCLPNHEB, Sprite BBFDELDIDOG, AudioClip BKGCLBJFADE, bool IGHBADHOACF, Dictionary<string, UnityEngine.Object> CJFFPFEHNFI, string IJHEEPGHPBJ = null, ulong CDAGKANOOHO = 0uL)
	{
		mapData = CLCBMMEKBBC;
		fullLevelPath = FJDHGDHKNNG;
		source = HLBKCLPNHEB;
		icon = BBFDELDIDOG;
		clip = BKGCLBJFADE;
		resources = CJFFPFEHNFI;
		workshopId = IJHEEPGHPBJ;
		mapperSteamID = CDAGKANOOHO;
	}

	public bool FIIAFIAFIFI()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool OAPGACFDFHG()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool IEFPMIPMJLC()
	{
		bool flag = true;
		string hFEFHOPOLIK = "Out {0,4} | In {1,4} | Sum {2,4}" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_ScreenResolution";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1) != 0 && false;
	}

	public int LBHGHDODFJB()
	{
		int num = 1;
		string hFEFHOPOLIK = "_Offsets" + Singleton<MapsSystem>.Instance.GetMapID(this) + "NOISE";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1);
	}

	public int ALEKPPCEBED()
	{
		int num = 0;
		string hFEFHOPOLIK = "[NetworkManager] Connection failed: " + Singleton<MapsSystem>.Instance.GetMapID(this) + "unsubscribemap";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public int GLCFHMJMFKD()
	{
		int num = 0;
		string hFEFHOPOLIK = "player.slash" + Singleton<MapsSystem>.Instance.GetMapID(this) + " does not exist!";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public int EKBAMAAJEHJ()
	{
		int num = 1;
		string hFEFHOPOLIK = ". Not connectedAndReady." + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Amount";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0);
	}

	public int LBKCKENEFHI()
	{
		int num = 0;
		string hFEFHOPOLIK = "value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_FixDistance";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool KLKNPOJIJID()
	{
		bool flag = false;
		string hFEFHOPOLIK = "_ScreenResolution" + Singleton<MapsSystem>.Instance.GetMapID(this) + "FileMenu";
		return (Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 1) != 0) ? true : false;
	}

	public bool FAHBINIOHNO()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[1];
				array[1] = 'ﾾ';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 0)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array2[0]))
					{
						switch (array2[1])
						{
						case "DPADVER":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[0]) != int.Parse(array2[0]))
							{
								flag = true;
							}
							break;
						case "Adreno":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[1]) != float.Parse(array2[0], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "new round":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[0]) != ((!(array2[4] == ".r")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "ItemNameText":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array2[0]) != array2[8])
							{
								flag = true;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "CameraFilterPack/FX_Spot")
					{
						flag = false;
					}
					else
					{
						Debug.Log("CameraFilterPack/TV_ARCADE" + array2[0] + " room(s)");
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (IBFKBPHBNHJ())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public int PJPELKFHJHD()
	{
		int num = 1;
		string hFEFHOPOLIK = "_Offsets" + Singleton<MapsSystem>.Instance.GetMapID(this) + "settings.volume.game";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 1);
	}

	public bool MEAEFNFILMP()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool OILJCAEIMNF()
	{
		bool flag = true;
		string hFEFHOPOLIK = "Joystick1Button3" + Singleton<MapsSystem>.Instance.GetMapID(this) + "[PlayerController] ";
		return (Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1) != 0) ? true : false;
	}

	public bool GPLDMHOKOPN()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int FOPKPLELLII()
	{
		int num = 0;
		string hFEFHOPOLIK = "Delete events" + Singleton<MapsSystem>.Instance.GetMapID(this) + "offsets";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1);
	}

	public bool BCMGOPKDIOG()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool CBKKILEAMDA()
	{
		bool flag = true;
		string hFEFHOPOLIK = "_ScreenResolution" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Axis";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1) == 1;
	}

	public bool ONHIGNAACAM()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[1] = 'A';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 1)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[0]))
					{
						switch (array2[0])
						{
						case "_Near":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[1]) != int.Parse(array2[4]))
							{
								flag = false;
							}
							break;
						case "_Parameter":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[1]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "OxOD.lastPath":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array2[1]) != ((array2[0] == "ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass") ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "Bad parameters for set! Use <language>":
							if (Singleton<SaveSystem>.Instance.GetString(array2[1]) != array2[7])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[1] == "OK")
					{
						flag = true;
					}
					else
					{
						Debug.Log("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change" + array2[1] + "[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.");
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (MEOEHHDNAJH())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool HMKCHDJOHBP()
	{
		bool flag = true;
		string hFEFHOPOLIK = "_Value3" + Singleton<MapsSystem>.Instance.GetMapID(this) + "There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0) != 0 || true;
	}

	public bool ADIHOOELODI()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[1] = '?';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.OHIBODCDDKB(array2[0]))
					{
						switch (array2[0])
						{
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[0]) != int.Parse(array2[3]))
							{
								flag = false;
							}
							break;
						case "_MainTex2":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[1]) != float.Parse(array2[1], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "grid":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[0]) != ((!(array2[3] == "Create failed on GameServer. Changing back to MasterServer. Msg: ")) ? 0 : 0))
							{
								flag = true;
							}
							break;
						case ".png":
							if (Singleton<SaveSystem>.Instance.GetString(array2[0]) != array2[7])
							{
								flag = true;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "finished")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_SunThreshold" + array2[1] + "_TimeX");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (PNEMNELDEFD())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool JGPEHBLEIFE()
	{
		bool flag = true;
		string hFEFHOPOLIK = "0,1,false" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_TimeX";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1) != 0 || true;
	}

	public int GLFIKEGDOEA()
	{
		int num = 0;
		string hFEFHOPOLIK = "_Value2" + Singleton<MapsSystem>.Instance.GetMapID(this) + "-1";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool NAODDAJLPEF()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool CNFFJELPCPN()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool EIDHKCMLJNH()
	{
		bool flag = false;
		string hFEFHOPOLIK = "EventMenu" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_ScreenResolution";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) == 1;
	}

	public int PNGPCFHOCDA()
	{
		int num = 1;
		string hFEFHOPOLIK = "Unknown player asked for PickupItems" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_ScreenResolution";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1);
	}

	public bool JAHKEIMLNAO()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[0] = 'G';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 0)
				{
					if (Singleton<SaveSystem>.Instance.OHIBODCDDKB(array2[0]))
					{
						switch (array2[0])
						{
						case "_SoftZDistance":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array2[1]) != int.Parse(array2[2]))
							{
								flag = true;
							}
							break;
						case "SetParticlesColor":
							if (Singleton<SaveSystem>.Instance.GetFloat(array2[1]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_QualitySettings":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[0]) != ((!(array2[5] == "_TimeX")) ? 0 : 0))
							{
								flag = true;
							}
							break;
						case "Gameplay/particles":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array2[0]) != array2[3])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "_Alpha")
					{
						flag = true;
					}
					else
					{
						Debug.Log("plainText" + array2[0] + "s");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (OBJNELDHNOM())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool KDLDENCCOCD()
	{
		bool flag = false;
		if (source == MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[1];
				array[1] = '\uffc0';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 7)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array2[1]))
					{
						switch (array2[0])
						{
						case "SSAARenderTargetCamera":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[0]) != int.Parse(array2[2]))
							{
								flag = true;
							}
							break;
						case "CameraFilterPack/Blend2Camera_GreenScreen":
							if (Singleton<SaveSystem>.Instance.OOHMHLJADED(array2[0]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "settings.volume.menu":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[0]) != ((!(array2[2] == "/icon")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "_Offsets":
							if (Singleton<SaveSystem>.Instance.GetString(array2[0]) != array2[7])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "curScn")
					{
						flag = true;
					}
					else
					{
						Debug.Log("System.Int64" + array2[0] + "The given 2D texture ");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (MOLBDPJCIPL())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool MBOHPJLDFPM()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[1];
				array[1] = 'e';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 1)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array2[0]))
					{
						switch (array2[1])
						{
						case "Brightness":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array2[0]) != int.Parse(array2[0]))
							{
								flag = false;
							}
							break;
						case ".png":
							if (Singleton<SaveSystem>.Instance.HAMBEDDLMAG(array2[0]) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case ") but there is no recycle bin setup for it. Falling back to Instantiate":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[1]) != ((!(array2[1] == "Mouse2")) ? 1 : 1))
							{
								flag = false;
							}
							break;
						case "Horizontal":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array2[1]) != array2[3])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[0] == " is muted")
					{
						flag = false;
					}
					else
					{
						Debug.Log("Move environment object to the position" + array2[1] + "[LocalizationService] Loading file: ");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (JKCNBMOJNIG())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool PNEDDBEECLL()
	{
		bool flag = true;
		if (source == MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[1] = 'ￒ';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 7)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[0]))
					{
						switch (array2[1])
						{
						case "workshop.":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[1]) != int.Parse(array2[6]))
							{
								flag = false;
							}
							break;
						case "float,1.5":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[1]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case " timeUntilRespawn: ":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[1]) != ((!(array2[8] == "maps.")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "skin.hit_perfect":
							if (Singleton<SaveSystem>.Instance.GetString(array2[1]) != array2[8])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[1] == "_DistCenterScale")
					{
						flag = false;
					}
					else
					{
						Debug.Log("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com" + array2[1] + "_Val3");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (DEKLLANMOAE())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool PFCECGGLJCB()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool FKMIOKGNBLC()
	{
		bool flag = true;
		string hFEFHOPOLIK = "JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster." + Singleton<MapsSystem>.Instance.GetMapID(this) + "BadgeText";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0) != 1;
	}

	public bool GBEAOKJLEPN()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool DLAPKAHEACC()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool PJJNGCPKKAM()
	{
		bool flag = true;
		if (source == MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split('\ufff3');
				if (array.Length == 5)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array[1]))
					{
						switch (array[1])
						{
						case "_ScreenResolution":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array[0]) != int.Parse(array[7]))
							{
								flag = true;
							}
							break;
						case "_AOTex":
							if (Singleton<SaveSystem>.Instance.HAMBEDDLMAG(array[1]) != float.Parse(array[0], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_Value4":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array[1]) != ((!(array[6] == "_ScreenResolution")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case " Server: ":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[1]) != array[2])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[1] == "EditMenu")
					{
						flag = false;
					}
					else
					{
						Debug.Log("Data/Skins/" + array[1] + "maps.");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (DEFLKOHFCFA())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool isUnlocked()
	{
		bool flag = true;
		if (source == MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split(',');
				if (array.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[0]))
					{
						switch (array[1])
						{
						case "int":
							if (Singleton<SaveSystem>.Instance.GetInt(array[0]) != int.Parse(array[2]))
							{
								flag = false;
							}
							break;
						case "float":
							if (Singleton<SaveSystem>.Instance.GetFloat(array[0]) != float.Parse(array[2], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "bool":
							if (Singleton<SaveSystem>.Instance.GetInt(array[0]) != ((array[2] == "true") ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "string":
							if (Singleton<SaveSystem>.Instance.GetString(array[0]) != array[2])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array[1] == "bool")
					{
						flag = false;
					}
					else
					{
						Debug.Log("[MapsData] Key " + array[0] + " not found");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (isLevelCompleted())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool NHDDNFHEDFI()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int NFGIBHAOPMM()
	{
		int num = 0;
		string hFEFHOPOLIK = "_Value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "request";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public int PlayedCount()
	{
		int num = 0;
		string hFEFHOPOLIK = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + ".played";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool DNKFAKLFOLH()
	{
		bool flag = true;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[1];
				array[1] = 'ￜ';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 1)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[1]))
					{
						switch (array2[1])
						{
						case " not exist":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[1]) != int.Parse(array2[2]))
							{
								flag = false;
							}
							break;
						case "_ScreenResolution":
							if (Singleton<SaveSystem>.Instance.OOHMHLJADED(array2[0]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_Value4":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[0]) != ((!(array2[1] == "OxOD.lastPath")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "masterSteamID":
							if (Singleton<SaveSystem>.Instance.GetString(array2[1]) != array2[8])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[0] == "x")
					{
						flag = true;
					}
					else
					{
						Debug.Log("PopulateMapsList" + array2[0] + "#savemapchanges?");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (CJAHIIIKBGE())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool JKCNBMOJNIG()
	{
		bool flag = false;
		string hFEFHOPOLIK = "_AlphaUV" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_NoOuterClip";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) != 1;
	}

	public int BENGCHCJEHA()
	{
		int num = 0;
		string hFEFHOPOLIK = "CameraFilterPack/Glow_Glow_Color" + Singleton<MapsSystem>.Instance.GetMapID(this) + "<b><i>Map's Stats:</i></b>";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool OHOHAJLKEAK()
	{
		bool flag = false;
		string hFEFHOPOLIK = "Playing " + Singleton<MapsSystem>.Instance.GetMapID(this) + "/";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0) == 1;
	}

	public int KKDAFANMBAI()
	{
		int num = 0;
		string hFEFHOPOLIK = ".sawoutdatedmessage" + Singleton<MapsSystem>.Instance.GetMapID(this) + "Editor";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public bool LJDJLGHOHLE()
	{
		bool flag = true;
		if (source == MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split('\ufff1');
				if (array.Length == 1)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[1]))
					{
						switch (array[1])
						{
						case "Hex value #RRGGBB":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array[1]) != int.Parse(array[2]))
							{
								flag = true;
							}
							break;
						case " joined":
							if (Singleton<SaveSystem>.Instance.HAMBEDDLMAG(array[0]) != float.Parse(array[2], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_Near":
							if (Singleton<SaveSystem>.Instance.GetInt(array[0]) != ((!(array[7] == "CameraFilterPack/Blizzard")) ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "_BlurVector":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[0]) != array[2])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array[0] == "[DiscordController] Shutdown")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Green_G" + array[0] + "ItemsStoreButton");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (CBKKILEAMDA())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public int DFMNIGLJMDD()
	{
		int num = 0;
		string hFEFHOPOLIK = "Mid" + Singleton<MapsSystem>.Instance.GetMapID(this) + "CameraFilterPack/3D_Scan_Scene";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 1);
	}

	public int EAHCCJMMEEC()
	{
		int num = 1;
		string hFEFHOPOLIK = "OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);" + Singleton<MapsSystem>.Instance.GetMapID(this) + ".completedCount";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool HNOPJCAFNKP()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool IMNPJIDPELC()
	{
		bool flag = true;
		if (source == MapSource.Editor)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[0] = 'ﾂ';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 2)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[0]))
					{
						switch (array2[1])
						{
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array2[1]) != int.Parse(array2[6]))
							{
								flag = true;
							}
							break;
						case "FinalScoreSmallText":
							if (Singleton<SaveSystem>.Instance.OOHMHLJADED(array2[0]) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "maps.":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[1]) != ((!(array2[1] == "offsets")) ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "_Offsets":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array2[0]) != array2[8])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "_Speed")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Value4" + array2[1] + "CameraFilterPack/Drawing_Halftone");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (PLBLEHHPLJA())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool KCBBGGCDJKI()
	{
		bool flag = false;
		if (source == MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split('x');
				if (array.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array[1]))
					{
						switch (array[1])
						{
						case "DifficultyBG":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array[1]) != int.Parse(array[3]))
							{
								flag = true;
							}
							break;
						case ": ":
							if (Singleton<SaveSystem>.Instance.GetFloat(array[1]) != float.Parse(array[5], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_PColor2":
							if (Singleton<SaveSystem>.Instance.GetInt(array[1]) != ((array[7] == "-1") ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "_BlurParams":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[1]) != array[0])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[1] == "_Green_R")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Green_B" + array[1] + "_NormalAndRoughnessTexture");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (HMKCHDJOHBP())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool IJALKKJMGKB()
	{
		bool flag = true;
		string hFEFHOPOLIK = "#restart" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Bloom3";
		return (Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1) == 0) ? true : false;
	}

	public bool EIPNJLAFKLE()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int LLKCKLNCINB()
	{
		int num = 0;
		string hFEFHOPOLIK = "player.crystal" + Singleton<MapsSystem>.Instance.GetMapID(this) + "CameraFilterPack/TV_WideScreenHV";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 1);
	}

	public bool BDPKJMBOAKG()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool IKBAOBMFDAI()
	{
		bool flag = false;
		if (source == MapSource.Editor)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[1] = '￪';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 5)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[0]))
					{
						switch (array2[0])
						{
						case "Despawn environment object by id":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[1]) != int.Parse(array2[5]))
							{
								flag = true;
							}
							break;
						case "{}":
							if (Singleton<SaveSystem>.Instance.OOHMHLJADED(array2[1]) != float.Parse(array2[5], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "CameraFilterPack_VHS1":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[0]) != ((!(array2[5] == "_Distortion")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "winter2020":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array2[0]) != array2[1])
							{
								flag = true;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "[MapsData] Preloading workshop")
					{
						flag = false;
					}
					else
					{
						Debug.Log("CameraFilterPack/TV_ARCADE_Fast" + array2[1] + "CameraFilterPack/Blend2Camera_HardLight");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (isLevelCompleted())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool IPNHBFMAKMJ()
	{
		bool flag = true;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[1];
				array[1] = '7';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 6)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[0]))
					{
						switch (array2[0])
						{
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array2[0]) != int.Parse(array2[8]))
							{
								flag = false;
							}
							break;
						case "Share":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[0]) != float.Parse(array2[3], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "maps.":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[1]) != ((!(array2[0] == "_ScreenResolution")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "_LoopCount":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array2[1]) != array2[2])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[0] == "closed")
					{
						flag = false;
					}
					else
					{
						Debug.Log("CompletedLevel" + array2[1] + "float,0");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (DEKLLANMOAE())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool EOLPKPBLLMP()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool PLBLEHHPLJA()
	{
		bool flag = true;
		string hFEFHOPOLIK = "duration" + Singleton<MapsSystem>.Instance.GetMapID(this) + "icon";
		return (Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) == 0) ? true : false;
	}

	public int LHNBHFBEDMA()
	{
		int num = 1;
		string hFEFHOPOLIK = "Authentication failed: '{0}' Code: {1}" + Singleton<MapsSystem>.Instance.GetMapID(this) + "intensity";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public int PFEFCFBOEEJ()
	{
		int num = 1;
		string hFEFHOPOLIK = "settings.enablehitsoundsinrelax" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Value2";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool IICBCPNOBNF()
	{
		bool flag = false;
		string hFEFHOPOLIK = "player.linea" + Singleton<MapsSystem>.Instance.GetMapID(this) + "ShowSprite";
		return (Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) == 0) ? true : false;
	}

	public bool DEFLKOHFCFA()
	{
		bool flag = false;
		string hFEFHOPOLIK = "achievements.26.progress" + Singleton<MapsSystem>.Instance.GetMapID(this) + "StopSounds";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) != 0 || true;
	}

	public int NHEIAAECBAP()
	{
		int num = 1;
		string hFEFHOPOLIK = " This is not possible to be called for standalone input. Please check your platform and code where this is called" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_BlurPass";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1);
	}

	public bool KACNLMOKJEH()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool NJGMKLIJEAL()
	{
		bool flag = true;
		if (source == MapSource.Editor)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[1] = 'l';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 6)
				{
					if (Singleton<SaveSystem>.Instance.OHIBODCDDKB(array2[1]))
					{
						switch (array2[0])
						{
						case "_Value6":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[0]) != int.Parse(array2[3]))
							{
								flag = true;
							}
							break;
						case "player.goldwatermelon":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[0]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "...":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[0]) != ((!(array2[4] == "] to be droppable")) ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "z":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[1]) != array2[3])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "/Assets/MyImage")
					{
						flag = false;
					}
					else
					{
						Debug.Log(": " + array2[1] + "Set Sun MinSize");
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (CBKKILEAMDA())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool EMLFACIAEAM()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool LNEHFGGGCBG()
	{
		bool flag = false;
		if (source == MapSource.Editor)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split(':');
				if (array.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.OHIBODCDDKB(array[1]))
					{
						switch (array[0])
						{
						case "_Value5":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array[0]) != int.Parse(array[0]))
							{
								flag = false;
							}
							break;
						case "Saved as: ":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array[0]) != float.Parse(array[7], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "Clear Environment":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array[1]) != ((!(array[0] == "Text")) ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "x":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array[1]) != array[7])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array[1] == "tintColor")
					{
						flag = false;
					}
					else
					{
						Debug.Log(" not exist" + array[1] + ".lastCheckpoint.powerupsScore");
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (OHOHAJLKEAK())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public int NKHFKIAHMIJ()
	{
		int num = 0;
		string hFEFHOPOLIK = "DPADHOR" + Singleton<MapsSystem>.Instance.GetMapID(this) + "CurrentTimeLabel";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0);
	}

	public FullMapData(FullMapData FICNDPKIGND)
	{
		mapData = new MapData(FICNDPKIGND.mapData);
		fullLevelPath = FICNDPKIGND.fullLevelPath;
		source = FICNDPKIGND.source;
		icon = FICNDPKIGND.icon;
		clip = FICNDPKIGND.clip;
		resources = new Dictionary<string, UnityEngine.Object>(FICNDPKIGND.resources.Count);
		foreach (KeyValuePair<string, UnityEngine.Object> resource in FICNDPKIGND.resources)
		{
			resources.Add(resource.Key, resource.Value);
		}
		workshopId = FICNDPKIGND.workshopId;
		mapperSteamID = FICNDPKIGND.mapperSteamID;
	}

	public bool HFDAPJIOKGO()
	{
		bool flag = true;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[0];
				array[1] = 'ﾘ';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 4)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array2[1]))
					{
						switch (array2[0])
						{
						case "scenes":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array2[0]) != int.Parse(array2[4]))
							{
								flag = true;
							}
							break;
						case "_Gain":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array2[0]) != float.Parse(array2[8], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "Case-Sensitive":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[1]) != ((array2[8] == "0.00/0.00") ? 1 : 0))
							{
								flag = false;
							}
							break;
						case " ":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0]) != array2[1])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[0] == "_Value")
					{
						flag = true;
					}
					else
					{
						Debug.Log("Joystick1Button0" + array2[0] + "tagElement");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (FKMIOKGNBLC())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool AFBIKGAODND()
	{
		bool flag = false;
		string hFEFHOPOLIK = "Bad parameters for set! Use <language>" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_ForegroundBlurExtrude";
		return (Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1) != 0) ? true : false;
	}

	public bool MBJEEAGJPJN()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool FPFLGHPOKAI()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split('x');
				if (array.Length == 8)
				{
					if (Singleton<SaveSystem>.Instance.OHIBODCDDKB(array[1]))
					{
						switch (array[1])
						{
						case "CameraFilterPack/Blend2Camera_Hue":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array[1]) != int.Parse(array[7]))
							{
								flag = true;
							}
							break;
						case "_Value3":
							if (Singleton<SaveSystem>.Instance.HAMBEDDLMAG(array[1]) != float.Parse(array[0], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array[0]) != ((!(array[5] == "_Threshhold")) ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "http":
							if (Singleton<SaveSystem>.Instance.GetString(array[1]) != array[3])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[0] == "SlidingArea")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_DepthLevel" + array[0] + "maps.");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (FIDJFGDCICN())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public int AMPPJANOIEL()
	{
		int num = 1;
		string hFEFHOPOLIK = "value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "tagElement";
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1);
	}

	public bool DEKLLANMOAE()
	{
		bool flag = false;
		string hFEFHOPOLIK = "_TimeX" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Lift";
		return (Singleton<SaveSystem>.Instance.HHBIEPMBICO(hFEFHOPOLIK, 1) != 0) ? true : false;
	}

	public bool EBOCANCDINH()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split('ﾙ');
				if (array.Length == 1)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[1]))
					{
						switch (array[0])
						{
						case "Result for ":
							if (Singleton<SaveSystem>.Instance.GetInt(array[0]) != int.Parse(array[8]))
							{
								flag = true;
							}
							break;
						case "SelectorMapsCountSlider":
							if (Singleton<SaveSystem>.Instance.OLHIEOKMOAK(array[1]) != float.Parse(array[1], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "remaining: {0:0.000}":
							if (Singleton<SaveSystem>.Instance.GetInt(array[1]) != ((!(array[0] == "BitsData")) ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "RoomNameText":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[1]) != array[8])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[0] == "_AdaptTex")
					{
						flag = false;
					}
					else
					{
						Debug.Log("Connected to gameserver." + array[0] + "?");
						flag = false;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (!flag)
			{
				if (IICBCPNOBNF())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool MEOEHHDNAJH()
	{
		bool flag = true;
		string hFEFHOPOLIK = "_ScreenResolution" + Singleton<MapsSystem>.Instance.GetMapID(this) + " not exist";
		return (Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1) == 0) ? true : false;
	}

	public bool BAEFEDFOHGN()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				string[] array = unlockCondition.Split('u');
				if (array.Length == 8)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array[0]))
					{
						switch (array[1])
						{
						case "_FixDistance":
							if (Singleton<SaveSystem>.Instance.JNLHMOEFMML(array[0]) != int.Parse(array[4]))
							{
								flag = true;
							}
							break;
						case "_ScreenResolution":
							if (Singleton<SaveSystem>.Instance.GetFloat(array[0]) != float.Parse(array[3], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "CameraFilterPack_Glasses_On3":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array[1]) != ((array[6] == "[ResourcesManager] Load image error: ") ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[0]) != array[5])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[1] == "_FullResolutionFiltering")
					{
						flag = true;
					}
					else
					{
						Debug.Log("_ScreenResolution" + array[0] + "Set Object Position");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (PLBLEHHPLJA())
				{
					flag = true;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public int FPOEDBCJNGA()
	{
		int num = 0;
		string hFEFHOPOLIK = "_Value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "88f00bdf0ad61b16b803971ebe071962";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool isLevelCompleted()
	{
		bool flag = false;
		string hFEFHOPOLIK = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + ".completed";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) == 1;
	}

	public bool PGMAMBPJLFK()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool AHPOPJGEDPA()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return false;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[1];
				array[1] = '\ufffb';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 2)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[0]))
					{
						switch (array2[1])
						{
						case "Object ID. Case-Sensitive":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[1]) != int.Parse(array2[1]))
							{
								flag = false;
							}
							break;
						case "resource":
							if (Singleton<SaveSystem>.Instance.HAMBEDDLMAG(array2[1]) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "Destroy(targetPhotonView) failed, cause targetPhotonView is null.":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[1]) != ((!(array2[1] == "Preparing content...")) ? 1 : 0))
							{
								flag = true;
							}
							break;
						case ". Sent by actorNr: ":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[1]) != array2[2])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "_TimeX")
					{
						flag = true;
					}
					else
					{
						Debug.Log("_TimeX" + array2[1] + " Time: ");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (DEFLKOHFCFA())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool PNEMNELDEFD()
	{
		bool flag = true;
		string hFEFHOPOLIK = "_Value1" + Singleton<MapsSystem>.Instance.GetMapID(this) + ". Possible scene loading in progress?";
		return (Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 0) == 0) ? true : false;
	}

	public int IGJDKEAGIPI()
	{
		int num = 0;
		string hFEFHOPOLIK = "settings.disablestoryboard" + Singleton<MapsSystem>.Instance.GetMapID(this) + "[NetworkManager] Connecting...";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool ANNACHGLEJC()
	{
		bool flag = false;
		if (source == MapSource.Original)
		{
			return true;
		}
		try
		{
			foreach (string unlockCondition in mapData.unlockConditions)
			{
				char[] array = new char[1];
				array[1] = '\ufff1';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 0)
				{
					if (Singleton<SaveSystem>.Instance.HBBEJIBFLHO(array2[0]))
					{
						switch (array2[0])
						{
						case "_Value":
							if (Singleton<SaveSystem>.Instance.POJCOIEGLEF(array2[0]) != int.Parse(array2[4]))
							{
								flag = false;
							}
							break;
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.GetFloat(array2[1]) != float.Parse(array2[3], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case ".a":
							if (Singleton<SaveSystem>.Instance.KOKJPDNJCAA(array2[0]) != ((array2[2] == "checkpoint") ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "\" for viewID ":
							if (Singleton<SaveSystem>.Instance.FDFHEKDDEID(array2[1]) != array2[3])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[1] == "_BlurCoe")
					{
						flag = true;
					}
					else
					{
						Debug.Log("_Near" + array2[0] + ",");
						flag = true;
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				if (isLevelCompleted())
				{
					flag = false;
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool CJAHIIIKBGE()
	{
		bool flag = true;
		string hFEFHOPOLIK = "[LevelEditorScene] Error: I/O Failure! :(" + Singleton<MapsSystem>.Instance.GetMapID(this) + "Source Object: ";
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(hFEFHOPOLIK, 1) != 0 || true;
	}

	public int GBHPANOIIJN()
	{
		int num = 1;
		string hFEFHOPOLIK = "_Line" + Singleton<MapsSystem>.Instance.GetMapID(this) + "threshold";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}
}
