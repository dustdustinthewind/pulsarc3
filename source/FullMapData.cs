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

	public int PEJKDKHOAGL()
	{
		int num = 1;
		string hFEFHOPOLIK = "_FgOverlap" + Singleton<MapsSystem>.Instance.GetMapID(this) + "editorVolume";
		return Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hFEFHOPOLIK, 1);
	}

	public bool MGOOJGFIBIA()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool CIJHLOJPEGD()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int EAEBLPBBMIF()
	{
		int num = 1;
		string hFEFHOPOLIK = "CameraFilterPack/Color_Sepia" + Singleton<MapsSystem>.Instance.GetMapID(this) + "PossibleMapMaxScoreText";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool ALKOICIAKON()
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
				string[] array = unlockCondition.Split('ￚ');
				if (array.Length == 4)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[0]))
					{
						switch (array[0])
						{
						case "AddEnvironmentSprite":
							if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array[0]) != int.Parse(array[5]))
							{
								flag = false;
							}
							break;
						case "_Smooth":
							if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array[0]) != float.Parse(array[1], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_FarCamera":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[1]) != ((!(array[5] == "player.xp")) ? 0 : 0))
							{
								flag = true;
							}
							break;
						case "Mid":
							if (Singleton<SaveSystem>.Instance.GetString(array[1]) != array[4])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[0] == "{0}_{1}")
					{
						flag = false;
					}
					else
					{
						Debug.Log(" not exist" + array[1] + "_Value3");
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
				if (NLOMMLOEMFD())
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

	public bool CDPJMPONHPP()
	{
		bool flag = false;
		string hFEFHOPOLIK = "[LocalizationService] All languages: " + Singleton<MapsSystem>.Instance.GetMapID(this) + "_InvRenderTargetSize";
		return (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hFEFHOPOLIK, 1) != 0) ? true : false;
	}

	public bool BFDEKPGIMNH()
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
				string[] array = unlockCondition.Split('ﾡ');
				if (array.Length == 5)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array[1]))
					{
						switch (array[1])
						{
						case "Set satellite trail length in seconds":
							if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array[1]) != int.Parse(array[0]))
							{
								flag = false;
							}
							break;
						case "[NetworkManager] Connected to ":
							if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[0]) != float.Parse(array[0], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "[EditorEvent] Exception: ":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[0]) != ((array[6] == "ConnectToMaster() disabled the offline mode. No longer offline.") ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "RanksButton":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array[0]) != array[5])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[0] == "{0}sec average:")
					{
						flag = true;
					}
					else
					{
						Debug.Log("EventTimeInputField" + array[0] + "_Distortion");
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
				if (DKPIPGNIILL())
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

	public bool OMGDEIDPPJO()
	{
		bool flag = true;
		string hFEFHOPOLIK = "GlassesColor2" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "<b>#";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hFEFHOPOLIK, 1) != 1 && false;
	}

	public int OEBJCMGAKIG()
	{
		int num = 0;
		string hFEFHOPOLIK = "RB" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "{0} hours ago";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hFEFHOPOLIK, 0);
	}

	public bool PJDJCGKHEIC()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int HFFDDPCGKGE()
	{
		int num = 0;
		string hFEFHOPOLIK = "SpeedSlider" + Singleton<MapsSystem>.Instance.GetMapID(this) + "CONTRAST";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hFEFHOPOLIK, 1);
	}

	public bool MLDFFCPMHHF()
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
				array[0] = '}';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[0]))
					{
						switch (array2[1])
						{
						case "MainButton":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[1]) != int.Parse(array2[4]))
							{
								flag = false;
							}
							break;
						case "NEW_ACHIEVEMENT_1_21":
							if (Singleton<SaveSystem>.Instance.GetFloat(array2[0]) != float.Parse(array2[3], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "_Near":
							if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[1]) != ((array2[1] == "_ScreenResolution") ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "workshop.":
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
					else if (array2[0] == "[ItemsHandler] No connection to item server: ")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_PrefilterOffs" + array2[0] + "#ok");
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
				if (BLDMPJOMGDN())
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

	public bool PKLOGJMINMG()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool PMFLELFGPJO()
	{
		bool flag = true;
		string hFEFHOPOLIK = "Y" + Singleton<MapsSystem>.Instance.GetMapID(this) + " not exist";
		return (Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hFEFHOPOLIK, 1) != 0) ? true : false;
	}

	public bool MBJKBLDPIGJ()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public int BOPGHGGEAMP()
	{
		int num = 0;
		string hFEFHOPOLIK = "Editor" + Singleton<MapsSystem>.Instance.GetMapID(this) + "MapConfig";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hFEFHOPOLIK, 1);
	}

	public bool CCBCIPKOBAF()
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
							if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array2[1]) != int.Parse(array2[6]))
							{
								flag = false;
							}
							break;
						case "Set sun emission (glow)":
							if (Singleton<SaveSystem>.Instance.GetFloat(array2[1]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "Sent count: ":
							if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array2[1]) != ((!(array2[8] == "LeaderboardsButton")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "skin.hit_perfect":
							if (Singleton<SaveSystem>.Instance.NBMEANCMGEH(array2[1]) != array2[8])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[1] == "CHROMATIC_ABERRATION")
					{
						flag = false;
					}
					else
					{
						Debug.Log(". We have no such PhotonView! Ignored this if you're leaving a room. State: " + array2[1] + "CameraFilterPack/Deep_OilPaintHQ");
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
				if (MDKFJHPDIKB())
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

	public bool OCEJPDINCLF()
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
				string[] array = unlockCondition.Split('\b');
				if (array.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[0]))
					{
						switch (array[1])
						{
						case "CameraFilterPack/Color_Switching":
							if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array[1]) != int.Parse(array[3]))
							{
								flag = false;
							}
							break;
						case " is muted":
							if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[1]) != float.Parse(array[8], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "_PosY":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[1]) != ((!(array[2] == "_Visualize")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "Move environment object to the position":
							if (Singleton<SaveSystem>.Instance.GetString(array[0]) != array[0])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array[1] == "CrosshairOpacitySlider")
					{
						flag = true;
					}
					else
					{
						Debug.Log("--------------------------------" + array[0] + "[PlayerController] ");
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
				if (HMKCHDJOHBP())
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
		bool flag = true;
		string hFEFHOPOLIK = "_Value4" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "RULES";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hFEFHOPOLIK, 0) != 0 || true;
	}

	public bool KPMGJOPLNAO()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool FNJACLINNAP()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool FOBKMKFNKKD()
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
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array[1]))
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
							if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[1]) != float.Parse(array[1], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "#rt":
							if (Singleton<SaveSystem>.Instance.GetInt(array[1]) != ((!(array[0] == "BitsData")) ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "RoomNameText":
							if (Singleton<SaveSystem>.Instance.CFLCJCJHNKD(array[1]) != array[8])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[0] == "_AdaptParams")
					{
						flag = false;
					}
					else
					{
						Debug.Log("Skipping EstablishEncryption. Protocol is secure." + array[0] + "Ok");
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
				if (HMKCHDJOHBP())
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

	public bool NLOMMLOEMFD()
	{
		bool flag = true;
		string hFEFHOPOLIK = "ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster." + Singleton<MapsSystem>.Instance.GetMapID(this) + "BadgeText";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) != 1;
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
				char[] array = new char[0];
				array[1] = '￪';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 5)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0]))
					{
						switch (array2[0])
						{
						case "Despawn environment object by id":
							if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[1]) != int.Parse(array2[5]))
							{
								flag = true;
							}
							break;
						case "{}":
							if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array2[1]) != float.Parse(array2[5], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "CameraFilterPack_VHS2":
							if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array2[0]) != ((!(array2[5] == "_Distortion")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "mapselector.filter.favoriteonly":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0]) != array2[1])
							{
								flag = true;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "maps.")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Value" + array2[1] + "CameraFilterPack/Blend2Camera_HardLight");
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
				if (PMFLELFGPJO())
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

	public bool LJDJLGHOHLE()
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
				char[] array = new char[1];
				array[1] = 'p';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 2)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0]))
					{
						switch (array2[0])
						{
						case "{0}sec average:":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[1]) != int.Parse(array2[4]))
							{
								flag = true;
							}
							break;
						case "_Distortion":
							if (Singleton<SaveSystem>.Instance.KIKJOOJFIJK(array2[0]) != float.Parse(array2[1], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "HitInRelaxMusicToggle":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[0]) != ((!(array2[2] == "In Main Menu")) ? 0 : 0))
							{
								flag = true;
							}
							break;
						case "_Value":
							if (Singleton<SaveSystem>.Instance.ELHODPGACDI(array2[0]) != array2[6])
							{
								flag = true;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[0] == "HandsCountSlider")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_ChangeRed" + array2[1] + "[");
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
				if (JKCNBMOJNIG())
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

	public bool OCAIILGBCIL()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int MODGBDKBPFH()
	{
		int num = 1;
		string hFEFHOPOLIK = "value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "checkpoint";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hFEFHOPOLIK, 1);
	}

	public bool MPFNDFFDLEE()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool OKMHKMIOAOL()
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
				array[0] = 'h';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 3)
				{
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0]))
					{
						switch (array2[1])
						{
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[1]) != int.Parse(array2[0]))
							{
								flag = false;
							}
							break;
						case "D-Pad Up":
							if (Singleton<SaveSystem>.Instance.KIKJOOJFIJK(array2[0]) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_VignetteTex":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[1]) != ((array2[2] == "Keeping GameObject in the scene: ") ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "[Right]":
							if (Singleton<SaveSystem>.Instance.ELHODPGACDI(array2[0]) != array2[8])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[0] == "_TimeX")
					{
						flag = true;
					}
					else
					{
						Debug.Log("_Intensity" + array2[0] + "_TimeX");
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
				if (NEOLBDBDGHC())
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

	public bool DHEEIODOKHO()
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
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array[1]))
					{
						switch (array[1])
						{
						case "InfoText":
							if (Singleton<SaveSystem>.Instance.GetInt(array[1]) != int.Parse(array[3]))
							{
								flag = true;
							}
							break;
						case " or ":
							if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[1]) != float.Parse(array[5], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_MainTex2":
							if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array[1]) != ((array[7] == "#forever") ? 1 : 0))
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
					else if (array[1] == "_Green_G")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Green_B" + array[1] + "_ReflectionTexture0");
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
				if (PIPAOGHLBEK())
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

	public int GACJAKOPOMH()
	{
		int num = 1;
		string hFEFHOPOLIK = "Editor/" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "gold";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hFEFHOPOLIK, 1);
	}

	public bool isLoaded()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool CNFFJELPCPN()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool ECBBEOAIGEJ()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool OFMOFIFNKBI()
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
				string[] array = unlockCondition.Split('\0');
				if (array.Length == 0)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array[0]))
					{
						switch (array[1])
						{
						case "Xbox Home":
							if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array[1]) != int.Parse(array[7]))
							{
								flag = true;
							}
							break;
						case "CameraFilterPack/3D_Mirror":
							if (Singleton<SaveSystem>.Instance.HLPKNPJIHKM(array[1]) != float.Parse(array[6], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case ",":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[1]) != ((array[3] == "ResetButton") ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "#91CCFF":
							if (Singleton<SaveSystem>.Instance.IPEDKOMAKPP(array[1]) != array[4])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array[1] == ". Going to authenticate anyways.")
					{
						flag = true;
					}
					else
					{
						Debug.Log("_Distortion" + array[0] + "_Value2");
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
				if (PIPAOGHLBEK())
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

	public bool DKPIPGNIILL()
	{
		bool flag = false;
		string hFEFHOPOLIK = "CameraFilterPack/Blend2Camera_Exclusion" + Singleton<MapsSystem>.Instance.GetMapID(this) + ": ";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hFEFHOPOLIK, 1) != 0 && false;
	}

	public int PlayedCount()
	{
		int num = 0;
		string hFEFHOPOLIK = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + ".played";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool LEOIFKNDNJH()
	{
		bool flag = false;
		string hFEFHOPOLIK = ":</b> " + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "CameraFilterPack/Atmosphere_Rain";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) != 0 || true;
	}

	public int ECIODFMIBHD()
	{
		int num = 0;
		string hFEFHOPOLIK = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + "Netw. Sim.";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hFEFHOPOLIK, 0);
	}

	public bool ADBIEAHEION()
	{
		bool flag = true;
		string hFEFHOPOLIK = "[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "From {0} at Index {1} \n";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hFEFHOPOLIK, 1) != 0 || true;
	}

	public bool DJOFFCOAKHO()
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
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[1]))
					{
						switch (array2[0])
						{
						case "End Value should be greater than the start value, values not changed":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0]) != int.Parse(array2[2]))
							{
								flag = true;
							}
							break;
						case "CameraFilterPack/Blend2Camera_GreenScreen":
							if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array2[0]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "settings.volume.game":
							if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[0]) != ((!(array2[2] == "player.redarc")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "_SpawnHeuristic":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0]) != array2[7])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "[PhotonMessageInfo: Sender='{1}' Senttime={0}]")
					{
						flag = true;
					}
					else
					{
						Debug.Log("System.Int64" + array2[0] + " cannot be used as a 3D LUT.");
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
				if (PMFLELFGPJO())
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

	public bool PNEDDBEECLL()
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
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array[0]))
					{
						switch (array[1])
						{
						case "_FixDistance":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[0]) != int.Parse(array[4]))
							{
								flag = true;
							}
							break;
						case "CameraFilterPack_Atmosphere_Rain_FX":
							if (Singleton<SaveSystem>.Instance.PEBDFGFNFBE(array[0]) != float.Parse(array[3], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "CameraFilterPack/Glasses_OnX":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array[1]) != ((array[6] == "file://") ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.CFLCJCJHNKD(array[0]) != array[5])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array[1] == "_HighlightSuppression")
					{
						flag = true;
					}
					else
					{
						Debug.Log("CameraFilterPack/TV_Vcr" + array[0] + "Set Object Position");
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
				if (NEOLBDBDGHC())
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

	public int IONLHCPKHHH()
	{
		int num = 1;
		string hFEFHOPOLIK = " This is not possible to be called for standalone input. Please check your platform and code where this is called" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_BlurPass";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hFEFHOPOLIK, 1);
	}

	public bool NEOLBDBDGHC()
	{
		bool flag = true;
		string hFEFHOPOLIK = "Message duration multiplier. Recomended 1" + Singleton<MapsSystem>.Instance.GetMapID(this) + "/";
		return (Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hFEFHOPOLIK, 0) == 0) ? true : false;
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

	public bool HELOOLFBJFP()
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
				char[] array = new char[0];
				array[0] = '\n';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 2)
				{
					if (Singleton<SaveSystem>.Instance.HasKey(array2[1]))
					{
						switch (array2[0])
						{
						case "VIGNETTE_DESAT":
							if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array2[0]) != int.Parse(array2[0]))
							{
								flag = true;
							}
							break;
						case "ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms":
							if (Singleton<SaveSystem>.Instance.GLDCKMNIIDE(array2[1]) != float.Parse(array2[4], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "UpdateNewsTileStart":
							if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array2[1]) != ((!(array2[6] == "CameraFilterPack_Atmosphere_Rain_FX")) ? 1 : 0))
							{
								flag = true;
							}
							break;
						case "[Up]":
							if (Singleton<SaveSystem>.Instance.IPEDKOMAKPP(array2[0]) != array2[5])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "_ScreenResolution")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Value3" + array2[1] + "Tab2Content");
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
				if (HMKCHDJOHBP())
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

	public bool KLNEJBEJFIG()
	{
		bool flag = true;
		string hFEFHOPOLIK = "CameraFilterPack/Vision_Warp" + Singleton<MapsSystem>.Instance.GetMapID(this) + "Curve texture";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hFEFHOPOLIK, 1) == 1;
	}

	public bool EBOCANCDINH()
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
				char[] array = new char[0];
				array[1] = '/';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 8)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[0]))
					{
						switch (array2[1])
						{
						case "_Value3":
							if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[0]) != int.Parse(array2[7]))
							{
								flag = false;
							}
							break;
						case "Spawn new environment object (sun, satellite etc) and sets its id":
							if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array2[0]) != float.Parse(array2[8], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_TimeX":
							if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[0]) != ((!(array2[8] == "_MainTex2")) ? 0 : 0))
							{
								flag = true;
							}
							break;
						case "offsets":
							if (Singleton<SaveSystem>.Instance.IPEDKOMAKPP(array2[0]) != array2[1])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[0] == "_EmissionColor")
					{
						flag = false;
					}
					else
					{
						Debug.Log("/" + array2[1] + "challenges.");
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

	public bool HMKCHDJOHBP()
	{
		bool flag = false;
		string hFEFHOPOLIK = "CameraFilterPack/Colors_HUE_Rotate" + Singleton<MapsSystem>.Instance.GetMapID(this) + "player.lollipop";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hFEFHOPOLIK, 1) != 0 && false;
	}

	public bool isLevelCompleted()
	{
		bool flag = false;
		string hFEFHOPOLIK = "maps." + Singleton<MapsSystem>.Instance.GetMapID(this) + ".completed";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) == 1;
	}

	public bool ANOAPDBPHEJ()
	{
		bool flag = false;
		string hFEFHOPOLIK = "_ScreenResolution" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_TimeX";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0) != 0 && false;
	}

	public bool ILGNBBPJEAL()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public bool ALFACFFDNLM()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int FJBBONCHGGP()
	{
		int num = 0;
		string hFEFHOPOLIK = "Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages." + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "_Value1";
		return Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hFEFHOPOLIK, 1);
	}

	public bool NGILJKKGOCI()
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
					if (Singleton<SaveSystem>.Instance.HasKey(array2[1]))
					{
						switch (array2[0])
						{
						case "_Value6":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0]) != int.Parse(array2[3]))
							{
								flag = true;
							}
							break;
						case "player.russia":
							if (Singleton<SaveSystem>.Instance.HLPKNPJIHKM(array2[0]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "...":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0]) != ((!(array2[4] == "]")) ? 1 : 0))
							{
								flag = false;
							}
							break;
						case "float,0":
							if (Singleton<SaveSystem>.Instance.IPEDKOMAKPP(array2[1]) != array2[3])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == ".png")
					{
						flag = false;
					}
					else
					{
						Debug.Log(" not exist" + array2[1] + "id");
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
				if (NLOMMLOEMFD())
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

	public bool MDKFJHPDIKB()
	{
		bool flag = false;
		string hFEFHOPOLIK = "value" + Singleton<MapsSystem>.Instance.GetMapID(this) + "SetPlayerDistance";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hFEFHOPOLIK, 1) != 1 && false;
	}

	public bool ENDBLADJEAN()
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
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0]))
					{
						switch (array2[1])
						{
						case "DPADHOR":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0]) != int.Parse(array2[0]))
							{
								flag = true;
							}
							break;
						case "_MaxBlurRadius":
							if (Singleton<SaveSystem>.Instance.KIKJOOJFIJK(array2[1]) != float.Parse(array2[0], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case "SetRoomStartTimestamp":
							if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array2[0]) != ((!(array2[4] == ".g")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "RarityImage":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[0]) != array2[8])
							{
								flag = true;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "_TimeX")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_TimeX" + array2[0] + "[NetworkManager] roomInfo.name: ");
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
				if (NEOLBDBDGHC())
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

	public int PJPELKFHJHD()
	{
		int num = 1;
		string hFEFHOPOLIK = "UseScanLineSize" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "[PlayerBase] SetPlayerDistance error: ";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hFEFHOPOLIK, 0);
	}

	public int DIKHIJIFJGM()
	{
		int num = 1;
		string hFEFHOPOLIK = "turn" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "_MainTex2";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hFEFHOPOLIK, 0);
	}

	public bool LFNHEMDIAFA()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public int EIJOBPLFDEI()
	{
		int num = 1;
		string hFEFHOPOLIK = "Editor/" + Singleton<MapsSystem>.Instance.GetMapID(this) + "Tab2Content";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 1);
	}

	public bool MEAEFNFILMP()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int JHIPKBIECOL()
	{
		int num = 0;
		string hFEFHOPOLIK = "shader.future" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hFEFHOPOLIK, 0);
	}

	public bool POJFNMCAJAC()
	{
		return mapData != null && icon != null && clip != null;
	}

	public bool KDKMPKPGLJI()
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
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[0]))
					{
						switch (array2[0])
						{
						case "_SoftZDistance":
							if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array2[1]) != int.Parse(array2[2]))
							{
								flag = true;
							}
							break;
						case "Set Particles Color":
							if (Singleton<SaveSystem>.Instance.DHAINALDNBG(array2[1]) != float.Parse(array2[6], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "Hidden/Subpixel Morphological Anti-aliasing":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[0]) != ((!(array2[5] == "_TimeX")) ? 0 : 0))
							{
								flag = true;
							}
							break;
						case "[Right]":
							if (Singleton<SaveSystem>.Instance.ELHODPGACDI(array2[0]) != array2[3])
							{
								flag = false;
							}
							break;
						default:
							flag = false;
							break;
						}
					}
					else if (array2[1] == "_Distance")
					{
						flag = true;
					}
					else
					{
						Debug.Log("cipherText" + array2[0] + "s");
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
				if (PIPAOGHLBEK())
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

	public bool HKEMIPBLILH()
	{
		bool flag = false;
		string hFEFHOPOLIK = "_EdgeSharpness" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "shader.frost";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hFEFHOPOLIK, 1) != 1 && false;
	}

	public int LLKCKLNCINB()
	{
		int num = 1;
		string hFEFHOPOLIK = "CameraFilterPack/Light_Rainbow2" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Value2";
		return Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hFEFHOPOLIK, 1);
	}

	public bool DPMPIPOCALF()
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
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array[1]))
					{
						switch (array[1])
						{
						case "Hex value #RRGGBB":
							if (Singleton<SaveSystem>.Instance.DNBCCNHDJDK(array[1]) != int.Parse(array[2]))
							{
								flag = true;
							}
							break;
						case " joined":
							if (Singleton<SaveSystem>.Instance.KIKJOOJFIJK(array[0]) != float.Parse(array[2], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "_Near":
							if (Singleton<SaveSystem>.Instance.PPBFNLHCKCP(array[0]) != ((!(array[7] == "_TimeX")) ? 1 : 0))
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
					else if (array[0] == "#discord{0}joinrequest")
					{
						flag = false;
					}
					else
					{
						Debug.Log("_Green_B" + array[0] + "ItemsStoreButton");
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
				if (ANOAPDBPHEJ())
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

	public bool PIPAOGHLBEK()
	{
		bool flag = false;
		string hFEFHOPOLIK = "Playing " + Singleton<MapsSystem>.Instance.GetMapID(this) + "/../";
		return Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hFEFHOPOLIK, 0) == 1;
	}

	public bool IJALKKJMGKB()
	{
		bool flag = false;
		string hFEFHOPOLIK = " " + Singleton<MapsSystem>.Instance.GetMapID(this) + "0.00";
		return (Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hFEFHOPOLIK, 1) != 0) ? true : false;
	}

	public int NMGNOGDAJBM()
	{
		int num = 0;
		string hFEFHOPOLIK = "Keeping GameObject in the scene: " + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "_Value3";
		return Singleton<SaveSystem>.Instance.ANECPPFPKAP(hFEFHOPOLIK, 0);
	}

	public bool DLAPKAHEACC()
	{
		return mapData == null || !(icon != null) || clip != null;
	}

	public int EEPMDAPCLAA()
	{
		int num = 0;
		string hFEFHOPOLIK = "float,2" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(this) + "_Visualize";
		return Singleton<SaveSystem>.Instance.GetInt(hFEFHOPOLIK, 0);
	}

	public bool DDEFCGDKGNJ()
	{
		return mapData != null && icon != null && clip != null;
	}

	public int GGMOOLJNBJH()
	{
		int num = 1;
		string hFEFHOPOLIK = "PlayMusic" + Singleton<MapsSystem>.Instance.GetMapID(this) + "_Offsets";
		return Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hFEFHOPOLIK, 0);
	}

	public int KKDAFANMBAI()
	{
		int num = 0;
		string hFEFHOPOLIK = "Left Stick Click" + Singleton<MapsSystem>.Instance.GetMapID(this) + "inventory.itemscash";
		return Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hFEFHOPOLIK, 0);
	}

	public bool GMMJNEOCBPI()
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
				array[0] = 'ﾠ';
				string[] array2 = unlockCondition.Split(array);
				if (array2.Length == 7)
				{
					if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP(array2[1]))
					{
						switch (array2[0])
						{
						case "[DiscordController] Shutdown":
							if (Singleton<SaveSystem>.Instance.JLPLKBDBIJC(array2[1]) != int.Parse(array2[5]))
							{
								flag = true;
							}
							break;
						case "[Left]":
							if (Singleton<SaveSystem>.Instance.EJEGKIDILDJ(array2[1]) != float.Parse(array2[7], CultureInfo.InvariantCulture))
							{
								flag = false;
							}
							break;
						case "BitsData":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[1]) != ((!(array2[2] == "LoadingStatusText")) ? 0 : 0))
							{
								flag = false;
							}
							break;
						case "OperationResponse unhandled: {0}":
							if (Singleton<SaveSystem>.Instance.CFLCJCJHNKD(array2[0]) != array2[5])
							{
								flag = false;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[0] == "The given 2D texture ")
					{
						flag = true;
					}
					else
					{
						Debug.Log("OK" + array2[1] + "_Value3");
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
				if (MDKFJHPDIKB())
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

	public bool FOAKIJPOHEH()
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
					if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(array2[0]))
					{
						switch (array2[0])
						{
						case "_Value2":
							if (Singleton<SaveSystem>.Instance.GetInt(array2[0]) != int.Parse(array2[4]))
							{
								flag = false;
							}
							break;
						case "_Value":
							if (Singleton<SaveSystem>.Instance.GetFloat(array2[1]) != float.Parse(array2[3], CultureInfo.InvariantCulture))
							{
								flag = true;
							}
							break;
						case ".a":
							if (Singleton<SaveSystem>.Instance.PKIEJKHMECB(array2[0]) != ((array2[2] == "Added event") ? 1 : 0))
							{
								flag = false;
							}
							break;
						case " Owner called.":
							if (Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(array2[1]) != array2[3])
							{
								flag = true;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else if (array2[1] == "_Offsets")
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
				if (JKCNBMOJNIG())
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

	public bool BLDMPJOMGDN()
	{
		bool flag = true;
		string hFEFHOPOLIK = "_Value2" + Singleton<MapsSystem>.Instance.GetMapID(this) + "#{0:00}{1}{2}";
		return (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(hFEFHOPOLIK, 0) == 0) ? true : false;
	}
}
