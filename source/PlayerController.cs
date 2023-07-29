// PlayerController
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public enum Direction
	{
		Up,
		Right,
		Down,
		Left,
		PowerUp
	}

	public LayerMask arksLayerMask;

	public LayerMask powerupsLayerMask;

	public bool isRecording;

	public bool isSpectator;

	public List<GameObject> objects;

	private Vector3 JDAPEMPBJKM;

	public Vector3 delta = new Vector3(5f, 5f, 1f);

	public float lerpSpeed = 5f;

	public bool loseOnWrongKey = true;

	public bool useComboSystem;

	[HideInInspector]
	private List<string> PIHEMHOGGPL = new List<string> { "note.0", "note.1", "note.2", "note.3", "note.4", "note.5", "note.6", "note.7", "powerup.0", "powerup.1" };

	[HideInInspector]
	public List<Direction> currentCombo;

	public float currentComboTimeout = 0.15f;

	[HideInInspector]
	public List<PlayerControllerKeyHandler> keys = new List<PlayerControllerKeyHandler>();

	private float AJPABMEPCDO = 1f;

	private bool JDHHBDEAEID = true;

	private float OMGIMLPPNFI = 0.1f;

	private PlayerBase HFNAKOHHIAF;

	private float FNEPAIOLEOD = 0.5f;

	private int ACODLKJMCJF = 1;

	private Vector3 MPNMOONBMII = default(Vector3);

	private bool ABINANMGBCE;

	private bool BDKICAKJKKJ;

	private bool DGLOHIKKOBA;

	private bool MOFDJECEOBO;

	[CompilerGenerated]
	private static Func<Direction, int> LNIJKGECNME;

	public bool HitSounds => JDHHBDEAEID;

	[HideInInspector]
	public PlayerBase playerBase
	{
		get
		{
			if (HFNAKOHHIAF != null)
			{
				return HFNAKOHHIAF;
			}
			return GetComponentInParent<PlayerBase>();
		}
		set
		{
			HFNAKOHHIAF = value;
		}
	}

	[SpecialName]
	public bool HMOFKPGCJCE()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public PlayerBase PELOCGBHJFO()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	public void AIFIMLBHNOM(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.KEGJGPOECHA() == "ArcsHitsoundTimeDelaySlider" && ((GameScene)Singleton<Scene>.Instance).FJGOEKJIPFD())
			{
				return;
			}
			GameObject gameObject = FMOHBPMDAOK(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && JHEFABODNPO().DCLNDDJJJMA().gameMode != 0)
				{
					if (playerBase.CIACEFBNDDJ().isMine)
					{
						PhotonView photonView = DFLDMFKFBPC().ACPGHFHDCIP();
						object[] array = new object[0];
						array[0] = true;
						photonView.PBMFBOOALKA("CameraFilterPack/Film_ColorPerfection", PhotonTargets.AllBufferedViaServer, array);
					}
				}
				else
				{
					++DMFKOAIAHDC().incorrectScore;
					JHEFABODNPO().currentCombo = 0;
					if (JDHHBDEAEID && NODPGAOEHGL().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.FCNBLDODPKG(3, UnityEngine.Random.Range(407f, 1587f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_ScreenResolution")
				{
					++ODHBANOIMPN().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && CCBCAICCJLD().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1455f - FNEPAIOLEOD) <= 425.0)) ? (1298f - FNEPAIOLEOD) : 496f);
						float max = 808f + FNEPAIOLEOD;
						if (num <= 1469f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					KEFGHEIOHON().GBHNDHLAJLI().KEKKFNNMLMG("SteamManager", PhotonTargets.MasterClient, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 892f;
					num3 = 0f - num2 * num2 / 1526f + 1873f;
					if (num3 > 1751f)
					{
						num3 = 863f;
					}
					if (num3 < 1256f)
					{
						num3 = 655f;
					}
					float num4 = ((!(num3 < 1526f)) ? 209f : ((1792f - num3) * num2 * num2));
					if (num3 >= 823f)
					{
						++EICAMMJELIE().perfectHits;
						PlayerBase obj = NODPGAOEHGL();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++NLIGEMDBEOA().correctScore;
					PlayerBase obj2 = DGNIAONOGKK();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)NLIGEMDBEOA().currentCombo;
					PlayerBase obj3 = JJPEGCHJJED();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = DMFKOAIAHDC();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)NODPGAOEHGL().accuracyScore) / (float)((int)KEFGHEIOHON().incorrectScore + (int)JHEFABODNPO().correctScore);
					if (JDHHBDEAEID && ODHBANOIMPN().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(915f - FNEPAIOLEOD) <= 1979.0)) ? (1508f - FNEPAIOLEOD) : 286f);
						float max2 = 1311f + FNEPAIOLEOD;
						if (num3 >= 1475f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					DFLDMFKFBPC().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1843f * ((820f - OMGIMLPPNFI) * 1647f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.MFDJLFOJAMF(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -72 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	public int GBLDJPCFLPC()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 0)
			{
				currentCombo = currentCombo.OrderBy(CMALDOOPBEB).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "MapEnd";
				}
				text = " " + text.Remove(text.Length - 0, 0) + "#";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("Scene" + currentCombo[1].ToString() + "_PColor");
		}
		return -1;
	}

	private GameObject AGGPFPNKMFC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1684f, 1233f, 448f);
		Vector3 vector2 = new Vector3(348f, 610f, 1118f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1444f, 1470f, 1759f);
		}
		if (ACODLKJMCJF == 1)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1389f, 250f, 943f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(350f, 1143f, 495f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1743f, 1693f, 1701f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1338f;
			vector.y = 642f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 497f;
			vector.y = 686f;
		}
		if (FLMFNIGKHKP == 8)
		{
			vector.x = 889f;
			vector.y = 1775f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1535f;
			vector.y = 88f;
		}
		bool flag = FLMFNIGKHKP != -100;
		RaycastHit hitInfo;
		if (Physics.Raycast(DNOKKLIKLAM().transform.position + vector + vector2, playerBase.transform.TransformDirection(Vector3.back), out hitInfo, 1788f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(DNOKKLIKLAM().transform.position + vector + vector2, NODPGAOEHGL().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 384f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(DGNIAONOGKK().transform.position + vector + vector2, NFANBIICAFM().transform.TransformDirection(Vector3.back) * 969f, Color.white, 983f);
		return null;
	}

	private static int NJHMHPKJDCL(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	[SpecialName]
	public void PKFFJEOBLGD(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	private GameObject AKBLLMJBONI(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1200f, 68f, 102f);
		Vector3 vector2 = new Vector3(1438f, 891f, 654f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1061f, 396f, 345f);
		}
		if (ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1951f, 1292f, 1027f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(574f, 205f, 523f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1424f, 1280f, 143f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1480f;
			vector.y = 805f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 1500f;
			vector.y = 1487f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1772f;
			vector.y = 180f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1716f;
			vector.y = 1575f;
		}
		bool flag = FLMFNIGKHKP == -2;
		RaycastHit hitInfo;
		if (Physics.Raycast(PELOCGBHJFO().transform.position + vector + vector2, DMFKOAIAHDC().transform.TransformDirection(Vector3.back), out hitInfo, 808f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(EICAMMJELIE().transform.position + vector + vector2, PELOCGBHJFO().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1392f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(ODHBANOIMPN().transform.position + vector + vector2, ODHBANOIMPN().transform.TransformDirection(Vector3.back) * 754f, Color.white, 843f);
		return null;
	}

	public int DJLACMJODFF()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(LKJEPINPFLC).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "_ScreenResolution";
				}
				text = "ResetButton" + text.Remove(text.Length - 1, 1) + "#no";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 1)
		{
			return Helpers.patternsMap.IndexOf("_ScreenResolution" + currentCombo[0].ToString() + "visible");
		}
		return -1;
	}

	public void GIGMGMDAJOG(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.GOMJAEIDHNM() == "_Value" && ((GameScene)Singleton<Scene>.Instance).KFFHJFIJHIC())
			{
				return;
			}
			GameObject gameObject = DMCMLADEEEK(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && NLIGEMDBEOA().GetGameScene().gameMode != 0)
				{
					if (NODPGAOEHGL().OELHGNKAMEG().BGJKMGJBPFA())
					{
						PhotonView photonView = CCBCAICCJLD().OELHGNKAMEG();
						object[] array = new object[0];
						array[0] = true;
						photonView.GNFNHDCJOFC("_Extra2", (PhotonTargets)7, array);
					}
				}
				else
				{
					++NFANBIICAFM().incorrectScore;
					DNOKKLIKLAM().currentCombo = 1;
					if (JDHHBDEAEID && JHEFABODNPO().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(732f, 307f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "RPCs can only be sent in rooms. Call of \"")
				{
					++EICAMMJELIE().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && NFANBIICAFM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(67f - FNEPAIOLEOD) <= 419.0)) ? (1216f - FNEPAIOLEOD) : 576f);
						float max = 1075f + FNEPAIOLEOD;
						if (num <= 1416f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
					}
					KEFGHEIOHON().GBMJAPGLMGB().IKIJDNPJKPM("In Main Menu", PhotonTargets.AllViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 285f;
					num3 = 0f - num2 * num2 / 1499f + 894f;
					if (num3 > 1384f)
					{
						num3 = 980f;
					}
					if (num3 < 1558f)
					{
						num3 = 1977f;
					}
					float num4 = ((!(num3 < 942f)) ? 635f : ((1177f - num3) * num2 * num2));
					if (num3 >= 1912f)
					{
						++NFANBIICAFM().perfectHits;
						PlayerBase obj = JHEFABODNPO();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++EICAMMJELIE().correctScore;
					PlayerBase obj2 = ODHBANOIMPN();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)JJPEGCHJJED().currentCombo;
					PlayerBase obj3 = KEFGHEIOHON();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = DGNIAONOGKK();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)DFLDMFKFBPC().accuracyScore) / (float)((int)NODPGAOEHGL().incorrectScore + (int)NODPGAOEHGL().correctScore);
					if (JDHHBDEAEID && ODHBANOIMPN().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(215f - FNEPAIOLEOD) <= 636.0)) ? (1782f - FNEPAIOLEOD) : 677f);
						float max2 = 1473f + FNEPAIOLEOD;
						if (num3 >= 1069f)
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					playerBase.UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 370f * ((832f - OMGIMLPPNFI) * 1522f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.MFDJLFOJAMF(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 47 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private void FIJHDKIPENG()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().BLMHOKPIMOD().isMine)
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				KJFEMNPENDO(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = JHEFABODNPO().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[6], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[4], 8, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[5], 8, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[0], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[2], 2, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("settings_bindings_controller_type", 1390f);
			if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "hidden")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("sounds/hit_wrong", 1) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && Singleton<SaveSystem>.Instance.CMAFBKOEPLP(" | ", 0) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Joystick1Button0", 1785f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("maps.", 396f);
		}
	}

	private void POEMOLBJDLG()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = false;
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[5]) || hardInput.GetKey(PIHEMHOGGPL[0]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = true;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.MFMIODIAKNI();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					playerBase.HJAHIPPLLDJ(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	[SpecialName]
	public PlayerBase DGNIAONOGKK()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public bool CPEJFCKHKOL()
	{
		return JDHHBDEAEID;
	}

	private void OHFOLGANOLC()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().GBHNDHLAJLI().KCAOJFPDEIP())
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				OADIPGANJAM(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = DNOKKLIKLAM().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[3], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[2], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[4], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 6, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[2], 6, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[5], 3, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[6], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[92], 2, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Texture2", 1579f);
			if (Singleton<Scene>.Instance.EMOAHNADEHK() == "_Value2")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("Coroutine container not configured... did you forget to call Init?", 0) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("USE_CORNER_DETECTION", 0) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_TimeX", 1819f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(" has no method \"", 211f);
		}
	}

	[SpecialName]
	public void NFDDPIGLDBG(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public void NMCKPDLLBBG(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	public void CONKAILPANP(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.id == "Uploader" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = BHNJNLOHFLC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && DNOKKLIKLAM().DCLNDDJJJMA().gameMode != 0)
				{
					if (DFLDMFKFBPC().ACPGHFHDCIP().DOLKFPIABDD())
					{
						PhotonView photonView = JHEFABODNPO().ACPGHFHDCIP();
						object[] array = new object[0];
						array[0] = true;
						photonView.GNFNHDCJOFC("_Red_R", PhotonTargets.OthersBuffered, array);
					}
				}
				else
				{
					++EICAMMJELIE().incorrectScore;
					KEFGHEIOHON().currentCombo = 1;
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.FCNBLDODPKG(3, UnityEngine.Random.Range(700f, 705f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "\r")
				{
					++JJPEGCHJJED().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && DFLDMFKFBPC().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(144f - FNEPAIOLEOD) <= 862.0)) ? (49f - FNEPAIOLEOD) : 993f);
						float max = 1212f + FNEPAIOLEOD;
						if (num <= 710f)
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
					}
					JJPEGCHJJED().IBKCMBIGOEJ().GNFNHDCJOFC("Object ID. Case-Sensitive", PhotonTargets.AllViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 151f;
					num3 = 0f - num2 * num2 / 1482f + 1810f;
					if (num3 > 1922f)
					{
						num3 = 167f;
					}
					if (num3 < 151f)
					{
						num3 = 1009f;
					}
					float num4 = ((!(num3 < 1461f)) ? 508f : ((1527f - num3) * num2 * num2));
					if (num3 >= 121f)
					{
						++playerBase.perfectHits;
						PlayerBase obj = DNOKKLIKLAM();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++DGNIAONOGKK().correctScore;
					PlayerBase obj2 = NLIGEMDBEOA();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)NODPGAOEHGL().currentCombo;
					PlayerBase obj3 = playerBase;
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = DGNIAONOGKK();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)JHEFABODNPO().accuracyScore) / (float)((int)HBDLLAKOFKJ().incorrectScore + (int)PELOCGBHJFO().correctScore);
					if (JDHHBDEAEID && PELOCGBHJFO().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(922f - FNEPAIOLEOD) <= 550.0)) ? (1277f - FNEPAIOLEOD) : 1956f);
						float max2 = 44f + FNEPAIOLEOD;
						if (num3 >= 858f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					PELOCGBHJFO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1933f * ((1647f - OMGIMLPPNFI) * 1254f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 54 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private void NNFMIAFHMJM()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().AAMNKPHHHCI().DOLKFPIABDD())
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				PFECOLHJNIM(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = JHEFABODNPO().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[5], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 3, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[2], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[6], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[3], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[25], 6, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Object ID. Case-Sensitive", 1722f);
			if (Singleton<Scene>.Instance.KCGOFGJNCME() == "\r")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("_Near", 1) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("Mouse ", 0) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("[Singleton] multiple instances of '", 198f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("restrictions\n\n#until: ", 50f);
		}
	}

	private static int DCDDFEHJBNO(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private static int NBEGHEOCMIO(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	public int HFKKBJFPABL()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 0)
			{
				currentCombo = currentCombo.OrderBy(DBMFINNHKGA).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "[MapsData] Found ";
				}
				text = "_Value" + text.Remove(text.Length - 1, 1) + "inventory.selected.";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("_ScreenResolution" + currentCombo[1].ToString() + "Error: Timeout :S");
		}
		return -1;
	}

	private static int DBMFINNHKGA(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	[SpecialName]
	public PlayerBase EICAMMJELIE()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void Update()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = false;
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[5]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[3]) || hardInput.GetKey(PIHEMHOGGPL[7]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.GetKey(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[2]) || hardInput.GetKey(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = true;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.Update();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					playerBase.RecordAction(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	[SpecialName]
	public PlayerBase NODPGAOEHGL()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void HJPCJGOEKMF()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().EOOCGIFFKBG().isMine)
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				BGGJDCJGFFN(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = EICAMMJELIE().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 5, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 2, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[0], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[3], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[-59], 2, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_TimeX", 1665f);
			if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "_Saturation")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("CameraFilterPack/Blend2Camera_ColorBurn", 0) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.CMAFBKOEPLP("skin.", 0) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_ScreenResolution", 1543f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Loading inventory", 155f);
		}
	}

	[SpecialName]
	public bool PAGJGFIGBNJ()
	{
		return JDHHBDEAEID;
	}

	private static int ICBKBIOCAKL(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	[SpecialName]
	public void GFAAIOBADNN(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public PlayerBase CCBCAICCJLD()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public PlayerBase JHEFABODNPO()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private GameObject LOKEFJGIFNK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1307f, 1461f, 1025f);
		Vector3 vector2 = new Vector3(1309f, 294f, 992f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(32f, 1034f, 1613f);
		}
		if (ACODLKJMCJF == 3)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1794f, 815f, 1004f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(1166f, 1164f, 1307f);
			}
			if (HMPOIDIAIMI == 5)
			{
				vector2 = new Vector3(1123f, 1151f, 32f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 175f;
			vector.y = 1790f;
		}
		if (FLMFNIGKHKP == 2)
		{
			vector.x = 0f;
			vector.y = 1995f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 1192f;
			vector.y = 131f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 747f;
			vector.y = 1137f;
		}
		bool flag = FLMFNIGKHKP == 99;
		RaycastHit hitInfo;
		if (Physics.Raycast(EICAMMJELIE().transform.position + vector + vector2, ODHBANOIMPN().transform.TransformDirection(Vector3.back), out hitInfo, 733f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(DFLDMFKFBPC().transform.position + vector + vector2, DFLDMFKFBPC().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 909f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(NFANBIICAFM().transform.position + vector + vector2, NLIGEMDBEOA().transform.TransformDirection(Vector3.back) * 1490f, Color.white, 922f);
		return null;
	}

	private void FOLDLDLFFLM()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = false;
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[5]) || hardInput.GetKey(PIHEMHOGGPL[2]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[0]) || hardInput.GetKey(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[2]) || hardInput.GetKey(PIHEMHOGGPL[5]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = true;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.HLDFOJMHKNL();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					EICAMMJELIE().RecordAction(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	[SpecialName]
	public bool MJADKEGNKAC()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public PlayerBase NLIGEMDBEOA()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[CompilerGenerated]
	private static int OAEFKCKJNHC(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	[SpecialName]
	public bool MAKFPOGABLH()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public void OFMKPIFJNOA(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	private void LCHBFNIPBHB()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = false;
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[1]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[2]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[7]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = true;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.GPFJMKCGHGB();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					JJPEGCHJJED().HJAHIPPLLDJ(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void IDJKNBDKHBD()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().OELHGNKAMEG().isMine)
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				NMCKPDLLBBG(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = JJPEGCHJJED().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[5], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[6], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[2], 8, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[7], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[6], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[5], 5, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[-70], 2, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("#newhighscore", 1950f);
			if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "[MapEditor] Updating map assets")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.ANECPPFPKAP("_ScreenResolution", 0) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || (Singleton<SaveSystem>.Instance.GetInt("_Source", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OJHPDDLNAGH(",", 134f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Keeping GameObject in the scene: ", 1564f);
		}
	}

	private void JECMJNFGBGC()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().EDIJKHEMPAD().isMine)
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				OFMKPIFJNOA(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = DGNIAONOGKK().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[2], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[4], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[2], 3, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[7], 6, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[6], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[7], 3, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[125], 3, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("[LocalizationService] All languages: ", 517f);
			if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "D-Pad Up")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.GetInt(":", 0) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_Value3", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_ScreenResolution", 1500f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("float,1.5", 1339f);
		}
	}

	private static int GDMDCLGAFIK(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	[SpecialName]
	public PlayerBase DMFKOAIAHDC()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private static int NLLEPGKCAFH(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject BPECFHECJCK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1688f, 919f, 981f);
		Vector3 vector2 = new Vector3(1523f, 161f, 1661f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(1736f, 1371f, 206f);
		}
		if (ACODLKJMCJF == 6)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1564f, 1431f, 253f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1770f, 1602f, 833f);
			}
			if (HMPOIDIAIMI == 6)
			{
				vector2 = new Vector3(1824f, 947f, 956f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1744f;
			vector.y = 1101f;
		}
		if (FLMFNIGKHKP == 4)
		{
			vector.x = 1926f;
			vector.y = 1899f;
		}
		if (FLMFNIGKHKP == 7)
		{
			vector.x = 1779f;
			vector.y = 1530f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 733f;
			vector.y = 860f;
		}
		bool flag = FLMFNIGKHKP != -114;
		RaycastHit hitInfo;
		if (Physics.Raycast(HBDLLAKOFKJ().transform.position + vector + vector2, ODHBANOIMPN().transform.TransformDirection(Vector3.back), out hitInfo, 198f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(NODPGAOEHGL().transform.position + vector + vector2, JJPEGCHJJED().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 629f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(ODHBANOIMPN().transform.position + vector + vector2, DFLDMFKFBPC().transform.TransformDirection(Vector3.back) * 277f, Color.white, 1563f);
		return null;
	}

	private void JBMBNKOOENB()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = false;
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[1]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[6]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[4]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.OIBMHPIFAKK();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					NLIGEMDBEOA().RecordAction(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void DPOCLHCABII(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.PACECPHKLNE() == "float,0" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = AKBLLMJBONI(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && DGNIAONOGKK().GetGameScene().gameMode != 0)
				{
					if (DMFKOAIAHDC().photonView.KCAOJFPDEIP())
					{
						PhotonView photonView = NODPGAOEHGL().photonView;
						object[] array = new object[0];
						array[1] = false;
						photonView.GNFNHDCJOFC("setbool", PhotonTargets.Others, array);
					}
				}
				else
				{
					++NFANBIICAFM().incorrectScore;
					EICAMMJELIE().currentCombo = 0;
					if (JDHHBDEAEID && DNOKKLIKLAM().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PNOOHLGKOFH(2, UnityEngine.Random.Range(543f, 1024f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "ArcsDestroyDelaySlider")
				{
					++DFLDMFKFBPC().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && NFANBIICAFM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(388f - FNEPAIOLEOD) <= 838.0)) ? (523f - FNEPAIOLEOD) : 1602f);
						float max = 1561f + FNEPAIOLEOD;
						if (num <= 1576f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min, max));
						}
					}
					NODPGAOEHGL().GBMJAPGLMGB().IKIJDNPJKPM("FinalScoreText", PhotonTargets.AllBufferedViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1244f;
					num3 = 0f - num2 * num2 / 373f + 1896f;
					if (num3 > 348f)
					{
						num3 = 358f;
					}
					if (num3 < 1925f)
					{
						num3 = 1713f;
					}
					float num4 = ((!(num3 < 523f)) ? 745f : ((1647f - num3) * num2 * num2));
					if (num3 >= 201f)
					{
						++playerBase.perfectHits;
						PlayerBase obj = EICAMMJELIE();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++playerBase.correctScore;
					PlayerBase obj2 = DFLDMFKFBPC();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)DNOKKLIKLAM().currentCombo;
					PlayerBase obj3 = KEFGHEIOHON();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = NODPGAOEHGL();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)NLIGEMDBEOA().accuracyScore) / (float)((int)PELOCGBHJFO().incorrectScore + (int)JHEFABODNPO().correctScore);
					if (JDHHBDEAEID && NLIGEMDBEOA().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(285f - FNEPAIOLEOD) <= 1810.0)) ? (1915f - FNEPAIOLEOD) : 1373f);
						float max2 = 510f + FNEPAIOLEOD;
						if (num3 >= 101f)
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.HAPJJNMDBCO(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					JHEFABODNPO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 790f * ((664f - OMGIMLPPNFI) * 791f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.MFDJLFOJAMF(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -74 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	[SpecialName]
	public bool NJCKDLBJAGD()
	{
		return JDHHBDEAEID;
	}

	private void LIBGAKMKHJJ()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().CIACEFBNDDJ().BGJKMGJBPFA())
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				KJFEMNPENDO(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = NODPGAOEHGL().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[2], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[3], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 5, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[7], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[5], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[-89], 4, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("_MainTex2", 1758f);
			if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "_TimeX")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("_TimeX", 1) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.GetInt("challenges.", 0) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_Far", 1894f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_Value", 1412f);
		}
	}

	[SpecialName]
	public bool GLIGAKBIBPA()
	{
		return JDHHBDEAEID;
	}

	private static int DICBHLDJAOH(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	[SpecialName]
	public bool MPJDIKBOGEL()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public bool NEGHFGAOPAJ()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public bool PJBOPNEOFIC()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public PlayerBase ODHBANOIMPN()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public bool KIGGFMAPEGJ()
	{
		return JDHHBDEAEID;
	}

	private GameObject IHPLCFKOBND(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(314f, 158f, 1151f);
		Vector3 vector2 = new Vector3(1301f, 1555f, 1923f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(134f, 1859f, 1300f);
		}
		if (ACODLKJMCJF == 0)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1445f, 203f, 725f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(381f, 897f, 144f);
			}
			if (HMPOIDIAIMI == 5)
			{
				vector2 = new Vector3(688f, 1971f, 1f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 411f;
			vector.y = 16f;
		}
		if (FLMFNIGKHKP == 2)
		{
			vector.x = 581f;
			vector.y = 845f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 1176f;
			vector.y = 1941f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 761f;
			vector.y = 469f;
		}
		bool flag = FLMFNIGKHKP != -99;
		RaycastHit hitInfo;
		if (Physics.Raycast(DGNIAONOGKK().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back), out hitInfo, 31f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(ODHBANOIMPN().transform.position + vector + vector2, DMFKOAIAHDC().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1762f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(EICAMMJELIE().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back) * 61f, Color.white, 530f);
		return null;
	}

	[SpecialName]
	public PlayerBase JJPEGCHJJED()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	public void HPBPJKFHMCD(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.CFADADIIOAM() == "OxOD.lastPath" && ((GameScene)Singleton<Scene>.Instance).FJGOEKJIPFD())
			{
				return;
			}
			GameObject gameObject = IHPLCFKOBND(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && playerBase.GetGameScene().gameMode != 0)
				{
					if (NFANBIICAFM().GBMJAPGLMGB().isMine)
					{
						PhotonView photonView = CCBCAICCJLD().EOOCGIFFKBG();
						object[] array = new object[1];
						array[1] = false;
						photonView.RPC(" [", (PhotonTargets)7, array);
					}
				}
				else
				{
					++JJPEGCHJJED().incorrectScore;
					JJPEGCHJJED().currentCombo = 0;
					if (JDHHBDEAEID && KEFGHEIOHON().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(3, UnityEngine.Random.Range(183f, 1070f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "/")
				{
					++EICAMMJELIE().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && KEFGHEIOHON().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1330f - FNEPAIOLEOD) <= 1433.0)) ? (1317f - FNEPAIOLEOD) : 1836f);
						float max = 1292f + FNEPAIOLEOD;
						if (num <= 751f)
						{
							SoundManager.HAPJJNMDBCO(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
					}
					NODPGAOEHGL().OELHGNKAMEG().MIAHMDGOOPJ("note.3", PhotonTargets.All, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1829f;
					num3 = 0f - num2 * num2 / 1897f + 1262f;
					if (num3 > 1118f)
					{
						num3 = 1188f;
					}
					if (num3 < 1586f)
					{
						num3 = 793f;
					}
					float num4 = ((!(num3 < 347f)) ? 319f : ((1666f - num3) * num2 * num2));
					if (num3 >= 302f)
					{
						++NFANBIICAFM().perfectHits;
						PlayerBase obj = JJPEGCHJJED();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++playerBase.correctScore;
					PlayerBase obj2 = NODPGAOEHGL();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)DMFKOAIAHDC().currentCombo;
					PlayerBase obj3 = CCBCAICCJLD();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = ODHBANOIMPN();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)playerBase.accuracyScore) / (float)((int)DNOKKLIKLAM().incorrectScore + (int)CCBCAICCJLD().correctScore);
					if (JDHHBDEAEID && NLIGEMDBEOA().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1367f - FNEPAIOLEOD) <= 130.0)) ? (1192f - FNEPAIOLEOD) : 1686f);
						float max2 = 818f + FNEPAIOLEOD;
						if (num3 >= 72f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					JHEFABODNPO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1795f * ((121f - OMGIMLPPNFI) * 330f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 116 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	[SpecialName]
	public bool IKKFHBNDNEG()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public bool HKFGAHHOCLI()
	{
		return JDHHBDEAEID;
	}

	public int BODCFCGDMDA()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(PNBKEIFHAAN).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "View";
				}
				text = "_TimeX" + text.Remove(text.Length - 1, 1) + "(scene)";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("Can't set visible when not in that room." + currentCombo[0].ToString() + "Set sun min/max size");
		}
		return -1;
	}

	private static int CMALDOOPBEB(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject BHNJNLOHFLC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(182f, 1733f, 1730f);
		Vector3 vector2 = new Vector3(1375f, 1034f, 618f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(317f, 1872f, 146f);
		}
		if (ACODLKJMCJF == 7)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(485f, 302f, 524f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1145f, 229f, 1682f);
			}
			if (HMPOIDIAIMI == 3)
			{
				vector2 = new Vector3(733f, 1534f, 460f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1605f;
			vector.y = 266f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1655f;
			vector.y = 520f;
		}
		if (FLMFNIGKHKP == 7)
		{
			vector.x = 962f;
			vector.y = 1732f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 177f;
			vector.y = 176f;
		}
		bool flag = FLMFNIGKHKP != 76;
		RaycastHit hitInfo;
		if (Physics.Raycast(KEFGHEIOHON().transform.position + vector + vector2, ODHBANOIMPN().transform.TransformDirection(Vector3.back), out hitInfo, 1216f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(DGNIAONOGKK().transform.position + vector + vector2, HBDLLAKOFKJ().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1035f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(DFLDMFKFBPC().transform.position + vector + vector2, HBDLLAKOFKJ().transform.TransformDirection(Vector3.back) * 118f, Color.white, 1105f);
		return null;
	}

	[SpecialName]
	public PlayerBase HBDLLAKOFKJ()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private GameObject IFKKCGODNIE(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1325f, 1903f, 711f);
		Vector3 vector2 = new Vector3(445f, 258f, 1675f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(1638f, 1714f, 987f);
		}
		if (ACODLKJMCJF == 6)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1889f, 419f, 658f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(1043f, 1780f, 972f);
			}
			if (HMPOIDIAIMI == 8)
			{
				vector2 = new Vector3(731f, 1989f, 1360f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1887f;
			vector.y = 871f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 416f;
			vector.y = 1591f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 1109f;
			vector.y = 455f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1554f;
			vector.y = 1103f;
		}
		bool flag = FLMFNIGKHKP != 10;
		RaycastHit hitInfo;
		if (Physics.Raycast(KEFGHEIOHON().transform.position + vector + vector2, DNOKKLIKLAM().transform.TransformDirection(Vector3.back), out hitInfo, 922f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(CCBCAICCJLD().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1426f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(KEFGHEIOHON().transform.position + vector + vector2, HBDLLAKOFKJ().transform.TransformDirection(Vector3.back) * 1155f, Color.white, 740f);
		return null;
	}

	private static int LBCCOLFINCB(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private void BMIOFJFMCBG()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().EDIJKHEMPAD().KCAOJFPDEIP())
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				PMIIAMPLFNI(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = DNOKKLIKLAM().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[5], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[7], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 8, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[3], 3, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[2], 7, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[1], 5, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[7], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[-16], 3, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.MFNCMBBPJPA(" not exist", 717f);
			if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "CameraFilterPack_Atmosphere_Rain_FX")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_FresnelFadePower", 1) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("<b>#", 1) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("{0:0} day{1}, ", 757f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("settings.arcsnohitsoundtimedelay", 72f);
		}
	}

	private void FJHFOBHJEHL()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[2]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[7]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[0]) || hardInput.GetKey(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[2]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[7]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.Update();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					DMFKOAIAHDC().RecordAction(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private static int NFHBMNGNOIH(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	[SpecialName]
	public PlayerBase DFLDMFKFBPC()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void FOMNCPKKCFN()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[8]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[7]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[4]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.GPFJMKCGHGB();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					ODHBANOIMPN().RecordAction(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public void BHMNLMFCJLE(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "SpectatingUserInfo" && ((GameScene)Singleton<Scene>.Instance).KFFHJFIJHIC())
			{
				return;
			}
			GameObject gameObject = DMCMLADEEEK(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && NLIGEMDBEOA().DCLNDDJJJMA().gameMode != 0)
				{
					if (playerBase.AAMNKPHHHCI().DOLKFPIABDD())
					{
						DFLDMFKFBPC().GMAHNPNHMFK().MIAHMDGOOPJ("Editor/", PhotonTargets.AllBuffered, new object[1] { false });
					}
				}
				else
				{
					++DNOKKLIKLAM().incorrectScore;
					NFANBIICAFM().currentCombo = 1;
					if (JDHHBDEAEID && JJPEGCHJJED().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(1041f, 259f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "\n")
				{
					++NODPGAOEHGL().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && HBDLLAKOFKJ().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1167f - FNEPAIOLEOD) <= 347.0)) ? (1737f - FNEPAIOLEOD) : 1617f);
						float max = 1331f + FNEPAIOLEOD;
						if (num <= 1447f)
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					CCBCAICCJLD().GBMJAPGLMGB().MIAHMDGOOPJ("time", PhotonTargets.AllBufferedViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1128f;
					num3 = 0f - num2 * num2 / 1420f + 113f;
					if (num3 > 1884f)
					{
						num3 = 1025f;
					}
					if (num3 < 1037f)
					{
						num3 = 1198f;
					}
					float num4 = ((!(num3 < 904f)) ? 737f : ((377f - num3) * num2 * num2));
					if (num3 >= 966f)
					{
						++CCBCAICCJLD().perfectHits;
						PlayerBase obj = KEFGHEIOHON();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++HBDLLAKOFKJ().correctScore;
					PlayerBase obj2 = DMFKOAIAHDC();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)JHEFABODNPO().currentCombo;
					PlayerBase obj3 = NFANBIICAFM();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = ODHBANOIMPN();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)DNOKKLIKLAM().accuracyScore) / (float)((int)DMFKOAIAHDC().incorrectScore + (int)JJPEGCHJJED().correctScore);
					if (JDHHBDEAEID && EICAMMJELIE().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1956f - FNEPAIOLEOD) <= 785.0)) ? (1866f - FNEPAIOLEOD) : 1359f);
						float max2 = 1009f + FNEPAIOLEOD;
						if (num3 >= 1682f)
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					DFLDMFKFBPC().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1458f * ((459f - OMGIMLPPNFI) * 1885f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -128 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	[SpecialName]
	public bool DFDJCONLKPA()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public bool NJKBNLLLJCI()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public void LCKNOFOLFNL(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public void BGGJDCJGFFN(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	private void FABKIGNFECE()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = false;
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[2]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[5]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[2]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = true;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.MAOCOEGAFND();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					NLIGEMDBEOA().ONOEOGGMDAP(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public int ALKGJEEHEBN()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(CMALDOOPBEB).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "_Value";
				}
				text = "_DotSize" + text.Remove(text.Length - 1, 0) + "icon.png";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("Can't do manual instantiation without PhotonView component." + currentCombo[1].ToString() + "CameraFilterPack/Distortion_Twist_Square");
		}
		return -1;
	}

	private void KDMANOEMOCA()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().BLMHOKPIMOD().DOLKFPIABDD())
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				GFAAIOBADNN(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = KEFGHEIOHON().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[6], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[3], 3, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[7], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[2], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[5], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[6], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[48], 7, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("/", 1728f);
			if (Singleton<Scene>.Instance.BDJMLNLIIMB() == "_TimeX")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.GetInt("Connection error: ", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.ANECPPFPKAP("Joystick1Button0", 1) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("VIGNETTE_DESAT", 1724f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("Tab1Content", 278f);
		}
	}

	[SpecialName]
	public bool CDFOGOEFHIF()
	{
		return JDHHBDEAEID;
	}

	public void PPJDDKHHDMP(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "ScreenResolutionPanel" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = AGGPFPNKMFC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && JHEFABODNPO().DCLNDDJJJMA().gameMode != 0)
				{
					if (NLIGEMDBEOA().AAMNKPHHHCI().KCAOJFPDEIP())
					{
						PhotonView photonView = DGNIAONOGKK().photonView;
						object[] array = new object[0];
						array[0] = true;
						photonView.IKIJDNPJKPM("EventSystem", (PhotonTargets)8, array);
					}
				}
				else
				{
					++NLIGEMDBEOA().incorrectScore;
					EICAMMJELIE().currentCombo = 0;
					if (JDHHBDEAEID && EICAMMJELIE().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(7, UnityEngine.Random.Range(1546f, 1967f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "UI")
				{
					++ODHBANOIMPN().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && HBDLLAKOFKJ().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(475f - FNEPAIOLEOD) <= 1083.0)) ? (1599f - FNEPAIOLEOD) : 305f);
						float max = 1979f + FNEPAIOLEOD;
						if (num <= 653f)
						{
							SoundManager.HAPJJNMDBCO(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min, max));
						}
					}
					ODHBANOIMPN().GMAHNPNHMFK().MIAHMDGOOPJ("error", (PhotonTargets)8, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1838f;
					num3 = 0f - num2 * num2 / 777f + 1632f;
					if (num3 > 842f)
					{
						num3 = 1090f;
					}
					if (num3 < 87f)
					{
						num3 = 1583f;
					}
					float num4 = ((!(num3 < 964f)) ? 1550f : ((183f - num3) * num2 * num2));
					if (num3 >= 1702f)
					{
						++NODPGAOEHGL().perfectHits;
						PlayerBase obj = DFLDMFKFBPC();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++JJPEGCHJJED().correctScore;
					PlayerBase obj2 = DMFKOAIAHDC();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)DMFKOAIAHDC().currentCombo;
					PlayerBase obj3 = JHEFABODNPO();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = PELOCGBHJFO();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)CCBCAICCJLD().accuracyScore) / (float)((int)DGNIAONOGKK().incorrectScore + (int)KEFGHEIOHON().correctScore);
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(719f - FNEPAIOLEOD) <= 1297.0)) ? (941f - FNEPAIOLEOD) : 259f);
						float max2 = 705f + FNEPAIOLEOD;
						if (num3 >= 1649f)
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					DNOKKLIKLAM().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1934f * ((1808f - OMGIMLPPNFI) * 773f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 73 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	[SpecialName]
	public bool JMEGFBEDAML()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public void OADIPGANJAM(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	public void AEDJKCPNEOC(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "#done" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = KJFGMJFMEFO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && NFANBIICAFM().GetGameScene().gameMode != 0)
				{
					if (playerBase.EOOCGIFFKBG().BGJKMGJBPFA())
					{
						PhotonView photonView = DGNIAONOGKK().EOOCGIFFKBG();
						object[] array = new object[0];
						array[1] = true;
						photonView.MIAHMDGOOPJ("Brightness", PhotonTargets.AllViaServer, array);
					}
				}
				else
				{
					++PELOCGBHJFO().incorrectScore;
					DFLDMFKFBPC().currentCombo = 1;
					if (JDHHBDEAEID && NLIGEMDBEOA().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(6, UnityEngine.Random.Range(1954f, 1707f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "Hex value #RRGGBB")
				{
					++KEFGHEIOHON().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && JJPEGCHJJED().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1629f - FNEPAIOLEOD) <= 878.0)) ? (1950f - FNEPAIOLEOD) : 710f);
						float max = 181f + FNEPAIOLEOD;
						if (num <= 1854f)
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min, max));
						}
					}
					HBDLLAKOFKJ().FFIPLLNKGEN().MIAHMDGOOPJ("12", (PhotonTargets)8, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1140f;
					num3 = 0f - num2 * num2 / 1584f + 632f;
					if (num3 > 1902f)
					{
						num3 = 1430f;
					}
					if (num3 < 577f)
					{
						num3 = 156f;
					}
					float num4 = ((!(num3 < 1880f)) ? 340f : ((1793f - num3) * num2 * num2));
					if (num3 >= 905f)
					{
						++NFANBIICAFM().perfectHits;
						PlayerBase obj = playerBase;
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++NLIGEMDBEOA().correctScore;
					PlayerBase obj2 = playerBase;
					obj2.comboScore = (float)obj2.comboScore + (float)(int)PELOCGBHJFO().currentCombo;
					PlayerBase obj3 = NFANBIICAFM();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = ODHBANOIMPN();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)JHEFABODNPO().accuracyScore) / (float)((int)KEFGHEIOHON().incorrectScore + (int)HBDLLAKOFKJ().correctScore);
					if (JDHHBDEAEID && DFLDMFKFBPC().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(907f - FNEPAIOLEOD) <= 1805.0)) ? (206f - FNEPAIOLEOD) : 334f);
						float max2 = 1834f + FNEPAIOLEOD;
						if (num3 >= 462f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					PELOCGBHJFO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 78f * ((1647f - OMGIMLPPNFI) * 1327f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.MFDJLFOJAMF(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -78 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private static int PNBKEIFHAAN(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private void POIMNOBDBBN()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[2]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[2]) || hardInput.GetKey(PIHEMHOGGPL[0]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = true;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.JNBPKNNBMDI();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					NLIGEMDBEOA().RecordAction(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void KCDOMIJBFLL()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = false;
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[5]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[2]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[2]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.GPFJMKCGHGB();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					DMFKOAIAHDC().RecordAction(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	[SpecialName]
	public PlayerBase KEFGHEIOHON()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private GameObject NKCPIGFJILI(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1539f, 1798f, 386f);
		Vector3 vector2 = new Vector3(1555f, 1979f, 1386f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(1594f, 1316f, 531f);
		}
		if (ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1769f, 80f, 718f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(324f, 1248f, 1332f);
			}
			if (HMPOIDIAIMI == 7)
			{
				vector2 = new Vector3(82f, 1142f, 1109f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 621f;
			vector.y = 225f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 1996f;
			vector.y = 429f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 1575f;
			vector.y = 1780f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1713f;
			vector.y = 1873f;
		}
		bool flag = FLMFNIGKHKP != -53;
		RaycastHit hitInfo;
		if (Physics.Raycast(CCBCAICCJLD().transform.position + vector + vector2, EICAMMJELIE().transform.TransformDirection(Vector3.back), out hitInfo, 262f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(JHEFABODNPO().transform.position + vector + vector2, PELOCGBHJFO().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 94f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(DNOKKLIKLAM().transform.position + vector + vector2, NODPGAOEHGL().transform.TransformDirection(Vector3.back) * 1072f, Color.white, 73f);
		return null;
	}

	private void NBGIMIDICKE()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().GBMJAPGLMGB().BGJKMGJBPFA())
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				OADIPGANJAM(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = EICAMMJELIE().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[3], 6, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[6], 3, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[0], 8, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[8], 8, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[3], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[-34], 0, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(". Possible scene loading in progress?", 1248f);
			if (Singleton<Scene>.Instance.KHDLEJLPGKP() == ".lastCheckpoint.time")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_EmissionColor", 0) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && Singleton<SaveSystem>.Instance.ANECPPFPKAP("st", 1) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Item ", 770f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.AKHCHNPPNIB(" method: ", 1505f);
		}
	}

	[SpecialName]
	public PlayerBase NFANBIICAFM()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private GameObject NDNFOGNNKOF(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1835f, 1019f, 1173f);
		Vector3 vector2 = new Vector3(319f, 652f, 1609f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(931f, 317f, 175f);
		}
		if (ACODLKJMCJF == 5)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(725f, 314f, 1816f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1323f, 1992f, 1768f);
			}
			if (HMPOIDIAIMI == 4)
			{
				vector2 = new Vector3(841f, 1440f, 129f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1822f;
			vector.y = 674f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 1211f;
			vector.y = 231f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 261f;
			vector.y = 732f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 100f;
			vector.y = 1770f;
		}
		bool flag = FLMFNIGKHKP != 33;
		RaycastHit hitInfo;
		if (Physics.Raycast(DFLDMFKFBPC().transform.position + vector + vector2, ODHBANOIMPN().transform.TransformDirection(Vector3.back), out hitInfo, 1977f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(NLIGEMDBEOA().transform.position + vector + vector2, CCBCAICCJLD().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 40f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(CCBCAICCJLD().transform.position + vector + vector2, JJPEGCHJJED().transform.TransformDirection(Vector3.back) * 1438f, Color.white, 1286f);
		return null;
	}

	public void NLPAHKLGJMK(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.JOAAANFJKIC() == "_PColor2" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = IHPLCFKOBND(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && EICAMMJELIE().GetGameScene().gameMode != 0)
				{
					if (HBDLLAKOFKJ().EOOCGIFFKBG().DOLKFPIABDD())
					{
						PhotonView photonView = NFANBIICAFM().FFIPLLNKGEN();
						object[] array = new object[0];
						array[1] = false;
						photonView.IKIJDNPJKPM("Start Color's hex value #RRGGBBAA", (PhotonTargets)7, array);
					}
				}
				else
				{
					++NODPGAOEHGL().incorrectScore;
					JHEFABODNPO().currentCombo = 0;
					if (JDHHBDEAEID && KEFGHEIOHON().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(8f, 1429f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "[MapEditor] Openning ")
				{
					++DGNIAONOGKK().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && PELOCGBHJFO().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(559f - FNEPAIOLEOD) <= 361.0)) ? (1423f - FNEPAIOLEOD) : 763f);
						float max = 759f + FNEPAIOLEOD;
						if (num <= 142f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					JJPEGCHJJED().EOOCGIFFKBG().KEKKFNNMLMG("_Value", (PhotonTargets)7, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1721f;
					num3 = 0f - num2 * num2 / 131f + 223f;
					if (num3 > 256f)
					{
						num3 = 203f;
					}
					if (num3 < 573f)
					{
						num3 = 1322f;
					}
					float num4 = ((!(num3 < 722f)) ? 1309f : ((593f - num3) * num2 * num2));
					if (num3 >= 1759f)
					{
						++NODPGAOEHGL().perfectHits;
						PlayerBase obj = CCBCAICCJLD();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++DNOKKLIKLAM().correctScore;
					PlayerBase obj2 = EICAMMJELIE();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)JJPEGCHJJED().currentCombo;
					PlayerBase obj3 = HBDLLAKOFKJ();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = CCBCAICCJLD();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)EICAMMJELIE().accuracyScore) / (float)((int)playerBase.incorrectScore + (int)JJPEGCHJJED().correctScore);
					if (JDHHBDEAEID && NLIGEMDBEOA().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(753f - FNEPAIOLEOD) <= 112.0)) ? (1529f - FNEPAIOLEOD) : 624f);
						float max2 = 1384f + FNEPAIOLEOD;
						if (num3 >= 160f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					NLIGEMDBEOA().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 800f * ((1187f - OMGIMLPPNFI) * 136f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -114 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private void AEOLJEIDMDB()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().CIACEFBNDDJ().KCAOJFPDEIP())
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				NFDDPIGLDBG(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = DFLDMFKFBPC().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[3], 8, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 6, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[2], 7, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[5], 7, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[-46], 8, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_Value13", 1498f);
			if (Singleton<Scene>.Instance.HLGJHICPDMO() == "FullscreenToggle")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_Value2", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || (Singleton<SaveSystem>.Instance.ANECPPFPKAP("_Value3", 0) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("0.00", 14f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("Object ID. Case-Sensitive", 829f);
		}
	}

	private static int DLFAILMGMEL(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private static int FEFLEOCHEDN(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private void ANCKKLFPGDI()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().BLMHOKPIMOD().BGJKMGJBPFA())
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				GFAAIOBADNN(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = HBDLLAKOFKJ().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[4], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[3], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[1], 3, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[5], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[51], 6, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Set Satellite Sensitivity", 795f);
			if (Singleton<Scene>.Instance.JOAAANFJKIC() == "_TimeX")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.ANECPPFPKAP("DPADHOR", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.CEKEOJDAEOD("<b>(╯°□°）╯︵ ┻━┻</b>", 0) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Keypad", 982f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("Item invalid. No idea why.", 86f);
		}
	}

	public void POFBCEKBIDH(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "_RampOffset" && ((GameScene)Singleton<Scene>.Instance).FJGOEKJIPFD())
			{
				return;
			}
			GameObject gameObject = AKBLLMJBONI(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && NLIGEMDBEOA().GetGameScene().gameMode != 0)
				{
					if (NODPGAOEHGL().JAEJDHHCJJO().isMine)
					{
						PhotonView photonView = HBDLLAKOFKJ().GMAHNPNHMFK();
						object[] array = new object[1];
						array[1] = true;
						photonView.MIAHMDGOOPJ("PublishButton", PhotonTargets.AllViaServer, array);
					}
				}
				else
				{
					++DMFKOAIAHDC().incorrectScore;
					PELOCGBHJFO().currentCombo = 1;
					if (JDHHBDEAEID && JJPEGCHJJED().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.HAPJJNMDBCO(5, UnityEngine.Random.Range(1242f, 1369f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_MainTex2")
				{
					++JJPEGCHJJED().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && KEFGHEIOHON().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1152f - FNEPAIOLEOD) <= 1152.0)) ? (1646f - FNEPAIOLEOD) : 1112f);
						float max = 1285f + FNEPAIOLEOD;
						if (num <= 749f)
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
					}
					JJPEGCHJJED().GBHNDHLAJLI().RPC("Case-Sensitive", PhotonTargets.OthersBuffered, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1590f;
					num3 = 0f - num2 * num2 / 623f + 1973f;
					if (num3 > 1672f)
					{
						num3 = 113f;
					}
					if (num3 < 1008f)
					{
						num3 = 39f;
					}
					float num4 = ((!(num3 < 240f)) ? 855f : ((1449f - num3) * num2 * num2));
					if (num3 >= 684f)
					{
						++DGNIAONOGKK().perfectHits;
						PlayerBase obj = DNOKKLIKLAM();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++NFANBIICAFM().correctScore;
					PlayerBase obj2 = ODHBANOIMPN();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)CCBCAICCJLD().currentCombo;
					PlayerBase obj3 = DGNIAONOGKK();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = CCBCAICCJLD();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)JJPEGCHJJED().accuracyScore) / (float)((int)PELOCGBHJFO().incorrectScore + (int)DMFKOAIAHDC().correctScore);
					if (JDHHBDEAEID && JJPEGCHJJED().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(425f - FNEPAIOLEOD) <= 767.0)) ? (970f - FNEPAIOLEOD) : 1578f);
						float max2 = 1777f + FNEPAIOLEOD;
						if (num3 >= 365f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					playerBase.UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1062f * ((1673f - OMGIMLPPNFI) * 1686f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -30 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private void LCDJFJIBADI()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = false;
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[2]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[3]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.MFMIODIAKNI();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					CCBCAICCJLD().ONOEOGGMDAP(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	public int PDKJFCMEIEE()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(CMALDOOPBEB).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "Mine";
				}
				text = "points:" + text.Remove(text.Length - 1, 1) + "_Value4";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 1)
		{
			return Helpers.patternsMap.IndexOf("MenuPlayButton" + currentCombo[0].ToString() + "catched: ");
		}
		return -1;
	}

	private void BMOFEBKGLFI()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().GMAHNPNHMFK().isMine)
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				NMCKPDLLBBG(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = HBDLLAKOFKJ().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[4], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 6, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[7], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[7], 5, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[-4], 5, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(".workshop.json", 860f);
			if (Singleton<Scene>.Instance.ALIGPAANMFA() == "remaining: {0:0.000}")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("#onfirstranktext", 0) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("_ScreenResolution", 1) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("mapselector.filter.favoriteonly", 377f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("/", 1873f);
		}
	}

	public void DBKJHNBJBKK(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.KCGOFGJNCME() == "Blues" && ((GameScene)Singleton<Scene>.Instance).KFFHJFIJHIC())
			{
				return;
			}
			GameObject gameObject = IHPLCFKOBND(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && JHEFABODNPO().GetGameScene().gameMode != 0)
				{
					if (NLIGEMDBEOA().GBMJAPGLMGB().isMine)
					{
						PhotonView photonView = DFLDMFKFBPC().FFIPLLNKGEN();
						object[] array = new object[0];
						array[0] = false;
						photonView.IKIJDNPJKPM("_ConsoleSettings", (PhotonTargets)8, array);
					}
				}
				else
				{
					++DMFKOAIAHDC().incorrectScore;
					DGNIAONOGKK().currentCombo = 0;
					if (JDHHBDEAEID && JHEFABODNPO().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(5, UnityEngine.Random.Range(1986f, 5f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "The process failed: ")
				{
					++playerBase.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1304f - FNEPAIOLEOD) <= 109.0)) ? (660f - FNEPAIOLEOD) : 1211f);
						float max = 1735f + FNEPAIOLEOD;
						if (num <= 1249f)
						{
							SoundManager.HAPJJNMDBCO(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min, max));
						}
					}
					EICAMMJELIE().OELHGNKAMEG().RPC("[LocalizationService] Loading file: ", (PhotonTargets)7, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1590f;
					num3 = 0f - num2 * num2 / 1644f + 664f;
					if (num3 > 835f)
					{
						num3 = 575f;
					}
					if (num3 < 777f)
					{
						num3 = 1972f;
					}
					float num4 = ((!(num3 < 1335f)) ? 760f : ((1848f - num3) * num2 * num2));
					if (num3 >= 685f)
					{
						++JHEFABODNPO().perfectHits;
						PlayerBase obj = playerBase;
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++JJPEGCHJJED().correctScore;
					PlayerBase obj2 = HBDLLAKOFKJ();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)NLIGEMDBEOA().currentCombo;
					PlayerBase obj3 = DMFKOAIAHDC();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = NFANBIICAFM();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)HBDLLAKOFKJ().accuracyScore) / (float)((int)playerBase.incorrectScore + (int)ODHBANOIMPN().correctScore);
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(886f - FNEPAIOLEOD) <= 1945.0)) ? (19f - FNEPAIOLEOD) : 135f);
						float max2 = 610f + FNEPAIOLEOD;
						if (num3 >= 14f)
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					KEFGHEIOHON().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1586f * ((1163f - OMGIMLPPNFI) * 1235f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -70 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	[SpecialName]
	public bool ODEEHAOHJBK()
	{
		return JDHHBDEAEID;
	}

	private void EIDKCANPHJE()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = false;
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[8]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[7]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[0]) || hardInput.GetKey(PIHEMHOGGPL[2]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[6]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[5]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.GPFJMKCGHGB();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					NFANBIICAFM().ONOEOGGMDAP(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	[SpecialName]
	public void KJFEMNPENDO(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	private void MFMIODIAKNI()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[6]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[5]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.LMBDNPLDGIJ();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					DMFKOAIAHDC().ONOEOGGMDAP(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	[SpecialName]
	public bool JJGHPHBHAIN()
	{
		return JDHHBDEAEID;
	}

	private GameObject KJFGMJFMEFO(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(0f, 0f, 16f);
		Vector3 vector2 = new Vector3(0f, 0f, 0f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(0f, 0f, 0f);
		}
		if (ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(0f, 0f, 0f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(-20f, 0f, 0f);
			}
			if (HMPOIDIAIMI == 2)
			{
				vector2 = new Vector3(20f, 0f, 0f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 0f;
			vector.y = 1.5f;
		}
		if (FLMFNIGKHKP == 2)
		{
			vector.x = 0f;
			vector.y = -1.5f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = -1.5f;
			vector.y = 0f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1.5f;
			vector.y = 0f;
		}
		bool flag = FLMFNIGKHKP != 9;
		RaycastHit hitInfo;
		if (Physics.Raycast(playerBase.transform.position + vector + vector2, playerBase.transform.TransformDirection(Vector3.back), out hitInfo, 30f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(playerBase.transform.position + vector + vector2, playerBase.transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(playerBase.transform.position + vector + vector2, playerBase.transform.TransformDirection(Vector3.back) * 30f, Color.white, 1f);
		return null;
	}

	public int GetCombo()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 0)
			{
				currentCombo = currentCombo.OrderBy((Direction HPHENPOHOMK) => (int)HPHENPOHOMK).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "-";
				}
				text = "[" + text.Remove(text.Length - 1, 1) + "]";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("[" + currentCombo[0].ToString() + "]");
		}
		return -1;
	}

	[SpecialName]
	public void PMIIAMPLFNI(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public bool HBGNCIPPOOL()
	{
		return JDHHBDEAEID;
	}

	private void KOJKBFDNGDK()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().AAMNKPHHHCI().BGJKMGJBPFA())
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				PMIIAMPLFNI(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = DGNIAONOGKK().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[3], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[4], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[2], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[7], 4, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[0], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[0], 5, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[-101], 2, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("Set satellite trail width", 240f);
			if (Singleton<Scene>.Instance.CFNPEEMCLJP() == "ArcsNoHitsoundTimeDelaySlider")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("CameraFilterPack/TV_WideScreenCircle", 1) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("PointsScoreText", 1) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("_Value4", 793f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("DifficultyBG", 1558f);
		}
	}

	public int FPFBFHALAJD()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 0)
			{
				currentCombo = currentCombo.OrderBy(FEFLEOCHEDN).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "_MaxBlurRadius";
				}
				text = "PhotonNetwork error: Could not Instantiate the prefab [" + text.Remove(text.Length - 1, 1) + "_CenterRadius";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("Bad parameters for getbool! Use <key> <value>" + currentCombo[0].ToString() + "GhostFade2");
		}
		return -1;
	}

	private void HMPGIFBJFIK()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().JAEJDHHCJJO().isMine)
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				GFAAIOBADNN(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = DFLDMFKFBPC().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[5], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[4], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[3], 6, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[5], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[3], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[6], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[5], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[-126], 4, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.DHFOFEJPGPP(" with a prefix of ", 1152f);
			if (Singleton<Scene>.Instance.KCGOFGJNCME() == "LevelNameInputField")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_EmissionGain", 0) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.JPEEFKKPFIL("[ItemsHandler] Inventory has changed", 0) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_BokehParams", 119f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("*.workshop.json", 865f);
		}
	}

	private GameObject HMMNKKFLIIE(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(994f, 1677f, 101f);
		Vector3 vector2 = new Vector3(1676f, 254f, 414f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(664f, 1506f, 63f);
		}
		if (ACODLKJMCJF == 4)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(208f, 1194f, 1068f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(179f, 1226f, 682f);
			}
			if (HMPOIDIAIMI == 8)
			{
				vector2 = new Vector3(1764f, 1755f, 1425f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 456f;
			vector.y = 692f;
		}
		if (FLMFNIGKHKP == 7)
		{
			vector.x = 717f;
			vector.y = 100f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 776f;
			vector.y = 964f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 867f;
			vector.y = 1432f;
		}
		bool flag = FLMFNIGKHKP != 61;
		RaycastHit hitInfo;
		if (Physics.Raycast(ODHBANOIMPN().transform.position + vector + vector2, CCBCAICCJLD().transform.TransformDirection(Vector3.back), out hitInfo, 264f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(playerBase.transform.position + vector + vector2, JJPEGCHJJED().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 875f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(NODPGAOEHGL().transform.position + vector + vector2, EICAMMJELIE().transform.TransformDirection(Vector3.back) * 40f, Color.white, 623f);
		return null;
	}

	public void CheckCombo(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.id == "GameScene" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = KJFGMJFMEFO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && playerBase.GetGameScene().gameMode != 0)
				{
					if (playerBase.photonView.isMine)
					{
						playerBase.photonView.RPC("LostLive", PhotonTargets.AllBuffered, true);
					}
				}
				else
				{
					++playerBase.incorrectScore;
					playerBase.currentCombo = 0;
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(2, UnityEngine.Random.Range(0.7f, 1.3f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "PowerUp")
				{
					++playerBase.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1f - FNEPAIOLEOD) <= 0.5)) ? (1f - FNEPAIOLEOD) : 0.5f);
						float max = 1f + FNEPAIOLEOD;
						if (num <= 2.5f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					playerBase.photonView.RPC("GetLive", PhotonTargets.AllBuffered, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 0f;
					num3 = 0f - num2 * num2 / 64f + 1.04f;
					if (num3 > 1f)
					{
						num3 = 1f;
					}
					if (num3 < 0f)
					{
						num3 = 0f;
					}
					float num4 = ((!(num3 < 1f)) ? 0f : ((1f - num3) * num2 * num2));
					if (num3 >= 0.75f)
					{
						++playerBase.perfectHits;
						PlayerBase obj = playerBase;
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++playerBase.correctScore;
					PlayerBase obj2 = playerBase;
					obj2.comboScore = (float)obj2.comboScore + (float)(int)playerBase.currentCombo;
					PlayerBase obj3 = playerBase;
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = playerBase;
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)playerBase.accuracyScore) / (float)((int)playerBase.incorrectScore + (int)playerBase.correctScore);
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1f - FNEPAIOLEOD) <= 0.5)) ? (1f - FNEPAIOLEOD) : 0.5f);
						float max2 = 1f + FNEPAIOLEOD;
						if (num3 >= 0.75f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					playerBase.UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 10f * ((0.4f - OMGIMLPPNFI) * 2f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 9 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	public int KNBOIOEKJID()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(DICBHLDJAOH).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "/";
				}
				text = "input" + text.Remove(text.Length - 0, 1) + "_Value";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("icon.png" + currentCombo[1].ToString() + "health");
		}
		return -1;
	}

	[SpecialName]
	public bool FKMLHDHIOJA()
	{
		return JDHHBDEAEID;
	}

	private GameObject GANPPIKGDDE(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1738f, 948f, 1708f);
		Vector3 vector2 = new Vector3(1974f, 450f, 110f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(118f, 499f, 1765f);
		}
		if (ACODLKJMCJF == 0)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(530f, 231f, 1405f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(913f, 341f, 1853f);
			}
			if (HMPOIDIAIMI == 4)
			{
				vector2 = new Vector3(88f, 1439f, 1322f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 703f;
			vector.y = 355f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 1620f;
			vector.y = 976f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 470f;
			vector.y = 840f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1921f;
			vector.y = 614f;
		}
		bool flag = FLMFNIGKHKP == -79;
		RaycastHit hitInfo;
		if (Physics.Raycast(ODHBANOIMPN().transform.position + vector + vector2, CCBCAICCJLD().transform.TransformDirection(Vector3.back), out hitInfo, 681f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(DMFKOAIAHDC().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1217f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(JJPEGCHJJED().transform.position + vector + vector2, DNOKKLIKLAM().transform.TransformDirection(Vector3.back) * 1128f, Color.white, 678f);
		return null;
	}

	public int MHMBDPMDDAC()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(DICBHLDJAOH).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "_Value3";
				}
				text = "hidden" + text.Remove(text.Length - 0, 0) + "SetParticlesInput";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("maps." + currentCombo[0].ToString() + "x");
		}
		return -1;
	}

	private GameObject HNLBLLNALJC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1930f, 1496f, 562f);
		Vector3 vector2 = new Vector3(589f, 1679f, 1818f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(293f, 111f, 1662f);
		}
		if (ACODLKJMCJF == 7)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(249f, 1332f, 248f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(1484f, 493f, 1112f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(83f, 1261f, 165f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 218f;
			vector.y = 1025f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 969f;
			vector.y = 1388f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 1348f;
			vector.y = 224f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1911f;
			vector.y = 411f;
		}
		bool flag = FLMFNIGKHKP == -79;
		RaycastHit hitInfo;
		if (Physics.Raycast(playerBase.transform.position + vector + vector2, DNOKKLIKLAM().transform.TransformDirection(Vector3.back), out hitInfo, 1030f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(DGNIAONOGKK().transform.position + vector + vector2, JJPEGCHJJED().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 810f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(DNOKKLIKLAM().transform.position + vector + vector2, PELOCGBHJFO().transform.TransformDirection(Vector3.back) * 1232f, Color.white, 991f);
		return null;
	}

	[SpecialName]
	public void PFECOLHJNIM(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	public void NBMHHGHIHDJ(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "Joystick1Button2" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = KJFGMJFMEFO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && JHEFABODNPO().DCLNDDJJJMA().gameMode != 0)
				{
					if (JHEFABODNPO().GMAHNPNHMFK().DOLKFPIABDD())
					{
						PhotonView photonView = PELOCGBHJFO().JAEJDHHCJJO();
						object[] array = new object[0];
						array[0] = false;
						photonView.GNFNHDCJOFC("_Value", (PhotonTargets)8, array);
					}
				}
				else
				{
					++NODPGAOEHGL().incorrectScore;
					playerBase.currentCombo = 0;
					if (JDHHBDEAEID && DFLDMFKFBPC().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.HAPJJNMDBCO(8, UnityEngine.Random.Range(149f, 418f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_MainTex2")
				{
					++NLIGEMDBEOA().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(505f - FNEPAIOLEOD) <= 1154.0)) ? (1351f - FNEPAIOLEOD) : 43f);
						float max = 226f + FNEPAIOLEOD;
						if (num <= 1736f)
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min, max));
						}
					}
					playerBase.photonView.KEKKFNNMLMG("[SoundManager] Loaded skin audio", (PhotonTargets)8, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1890f;
					num3 = 0f - num2 * num2 / 1122f + 1590f;
					if (num3 > 1333f)
					{
						num3 = 1933f;
					}
					if (num3 < 448f)
					{
						num3 = 1060f;
					}
					float num4 = ((!(num3 < 614f)) ? 1964f : ((1189f - num3) * num2 * num2));
					if (num3 >= 1084f)
					{
						++DNOKKLIKLAM().perfectHits;
						PlayerBase obj = DFLDMFKFBPC();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++NFANBIICAFM().correctScore;
					PlayerBase obj2 = EICAMMJELIE();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)playerBase.currentCombo;
					PlayerBase obj3 = playerBase;
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = DNOKKLIKLAM();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)ODHBANOIMPN().accuracyScore) / (float)((int)DFLDMFKFBPC().incorrectScore + (int)playerBase.correctScore);
					if (JDHHBDEAEID && NFANBIICAFM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(413f - FNEPAIOLEOD) <= 980.0)) ? (1390f - FNEPAIOLEOD) : 307f);
						float max2 = 573f + FNEPAIOLEOD;
						if (num3 >= 959f)
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					NFANBIICAFM().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1747f * ((1582f - OMGIMLPPNFI) * 470f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -73 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	public void LNAOENCHKGI(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.HLGJHICPDMO() == "_TimeX" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = NDNFOGNNKOF(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && DMFKOAIAHDC().DCLNDDJJJMA().gameMode != 0)
				{
					if (DNOKKLIKLAM().IBKCMBIGOEJ().isMine)
					{
						NFANBIICAFM().GMAHNPNHMFK().IKIJDNPJKPM("SetPosition", PhotonTargets.OthersBuffered, new object[1] { true });
					}
				}
				else
				{
					++DNOKKLIKLAM().incorrectScore;
					EICAMMJELIE().currentCombo = 0;
					if (JDHHBDEAEID && EICAMMJELIE().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.HAPJJNMDBCO(3, UnityEngine.Random.Range(1774f, 1032f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "Please wait..")
				{
					++KEFGHEIOHON().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && NODPGAOEHGL().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(510f - FNEPAIOLEOD) <= 1560.0)) ? (127f - FNEPAIOLEOD) : 364f);
						float max = 244f + FNEPAIOLEOD;
						if (num <= 623f)
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min, max));
						}
					}
					playerBase.CIACEFBNDDJ().PBMFBOOALKA("Sequence contains no elements", PhotonTargets.MasterClient, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 40f;
					num3 = 0f - num2 * num2 / 1341f + 300f;
					if (num3 > 817f)
					{
						num3 = 999f;
					}
					if (num3 < 231f)
					{
						num3 = 1807f;
					}
					float num4 = ((!(num3 < 1480f)) ? 739f : ((969f - num3) * num2 * num2));
					if (num3 >= 1997f)
					{
						++CCBCAICCJLD().perfectHits;
						PlayerBase obj = NLIGEMDBEOA();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++CCBCAICCJLD().correctScore;
					PlayerBase obj2 = DGNIAONOGKK();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)JJPEGCHJJED().currentCombo;
					PlayerBase obj3 = ODHBANOIMPN();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = NODPGAOEHGL();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)NFANBIICAFM().accuracyScore) / (float)((int)CCBCAICCJLD().incorrectScore + (int)NFANBIICAFM().correctScore);
					if (JDHHBDEAEID && NFANBIICAFM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(731f - FNEPAIOLEOD) <= 1865.0)) ? (896f - FNEPAIOLEOD) : 915f);
						float max2 = 328f + FNEPAIOLEOD;
						if (num3 >= 1532f)
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					NLIGEMDBEOA().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1425f * ((504f - OMGIMLPPNFI) * 826f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -117 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private void Start()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().photonView.isMine)
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				playerBase = GetComponentInParent<PlayerBase>();
				ACODLKJMCJF = playerBase.fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[2], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[3], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[4], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[5], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[6], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[7], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[9], 2, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("settings.cameramovements", 1f);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinnormal", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinrelax", 0) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("settings.hitvariation", 0.25f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("settings.arcsdestroydelay", 0.1f);
		}
	}

	private void GNCIOPKPLLA()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = false;
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[5]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[1]) || hardInput.GKLCHNPAEAL(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[6]) || hardInput.GetKey(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.Update();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					JHEFABODNPO().ONOEOGGMDAP(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}

	private void EGEPLFGKGLI()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().GBMJAPGLMGB().DOLKFPIABDD())
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				PFECOLHJNIM(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = EICAMMJELIE().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[2], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 6, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[2], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 3, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[5], 3, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[7], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[88], 1, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("SetSpeed", 979f);
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "Please wait..")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.ANECPPFPKAP("_Luminance", 1) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("/", 0) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("shader.frost", 1408f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("CameraFilterPack/FX_Dot_Circle", 1004f);
		}
	}

	private GameObject FMOHBPMDAOK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(456f, 255f, 66f);
		Vector3 vector2 = new Vector3(1042f, 1346f, 1074f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1952f, 572f, 132f);
		}
		if (ACODLKJMCJF == 8)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1401f, 20f, 132f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(4f, 1557f, 133f);
			}
			if (HMPOIDIAIMI == 5)
			{
				vector2 = new Vector3(1818f, 1583f, 1106f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1212f;
			vector.y = 520f;
		}
		if (FLMFNIGKHKP == 7)
		{
			vector.x = 1330f;
			vector.y = 418f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 1177f;
			vector.y = 1073f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 277f;
			vector.y = 1109f;
		}
		bool flag = FLMFNIGKHKP != -40;
		RaycastHit hitInfo;
		if (Physics.Raycast(NFANBIICAFM().transform.position + vector + vector2, HBDLLAKOFKJ().transform.TransformDirection(Vector3.back), out hitInfo, 132f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(NODPGAOEHGL().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 440f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(DNOKKLIKLAM().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back) * 1472f, Color.white, 692f);
		return null;
	}

	private static int IBIJNHEMBOO(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject DJHFDCLPHLF(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(269f, 306f, 136f);
		Vector3 vector2 = new Vector3(1584f, 1382f, 948f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(269f, 1853f, 992f);
		}
		if (ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(685f, 1307f, 921f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1154f, 39f, 1114f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(141f, 1212f, 1449f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 533f;
			vector.y = 372f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 285f;
			vector.y = 1339f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 1108f;
			vector.y = 613f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1355f;
			vector.y = 1964f;
		}
		bool flag = FLMFNIGKHKP != -92;
		RaycastHit hitInfo;
		if (Physics.Raycast(NFANBIICAFM().transform.position + vector + vector2, NFANBIICAFM().transform.TransformDirection(Vector3.back), out hitInfo, 1294f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(PELOCGBHJFO().transform.position + vector + vector2, NODPGAOEHGL().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1508f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(PELOCGBHJFO().transform.position + vector + vector2, KEFGHEIOHON().transform.TransformDirection(Vector3.back) * 1748f, Color.white, 1566f);
		return null;
	}

	public void OGACJDOPABH(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "_RgbDepthTex" && ((GameScene)Singleton<Scene>.Instance).KFFHJFIJHIC())
			{
				return;
			}
			GameObject gameObject = BHNJNLOHFLC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && playerBase.GetGameScene().gameMode != 0)
				{
					if (DMFKOAIAHDC().EOOCGIFFKBG().isMine)
					{
						PhotonView photonView = DMFKOAIAHDC().BLMHOKPIMOD();
						object[] array = new object[0];
						array[1] = true;
						photonView.KEKKFNNMLMG("warning: Audio Source: ", (PhotonTargets)7, array);
					}
				}
				else
				{
					++CCBCAICCJLD().incorrectScore;
					CCBCAICCJLD().currentCombo = 0;
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PNOOHLGKOFH(6, UnityEngine.Random.Range(830f, 737f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "CameraFilterPack/Real_VHS")
				{
					++JHEFABODNPO().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && DGNIAONOGKK().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(40f - FNEPAIOLEOD) <= 1347.0)) ? (1625f - FNEPAIOLEOD) : 632f);
						float max = 1826f + FNEPAIOLEOD;
						if (num <= 1925f)
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min, max));
						}
					}
					DGNIAONOGKK().BLMHOKPIMOD().RPC("roomDescription", PhotonTargets.AllViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 329f;
					num3 = 0f - num2 * num2 / 1520f + 1640f;
					if (num3 > 1784f)
					{
						num3 = 475f;
					}
					if (num3 < 137f)
					{
						num3 = 32f;
					}
					float num4 = ((!(num3 < 1238f)) ? 1808f : ((921f - num3) * num2 * num2));
					if (num3 >= 1697f)
					{
						++DGNIAONOGKK().perfectHits;
						PlayerBase obj = JHEFABODNPO();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++DNOKKLIKLAM().correctScore;
					PlayerBase obj2 = NODPGAOEHGL();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)PELOCGBHJFO().currentCombo;
					PlayerBase obj3 = NLIGEMDBEOA();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = NLIGEMDBEOA();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)playerBase.accuracyScore) / (float)((int)EICAMMJELIE().incorrectScore + (int)DNOKKLIKLAM().correctScore);
					if (JDHHBDEAEID && DNOKKLIKLAM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(823f - FNEPAIOLEOD) <= 1602.0)) ? (1761f - FNEPAIOLEOD) : 1101f);
						float max2 = 1988f + FNEPAIOLEOD;
						if (num3 >= 600f)
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					NODPGAOEHGL().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1858f * ((488f - OMGIMLPPNFI) * 1432f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -104 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	[SpecialName]
	public bool EENNMLHLCDF()
	{
		return JDHHBDEAEID;
	}

	private static int LKJEPINPFLC(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject DMCMLADEEEK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(244f, 1494f, 1112f);
		Vector3 vector2 = new Vector3(331f, 977f, 173f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(750f, 393f, 372f);
		}
		if (ACODLKJMCJF == 6)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(491f, 1890f, 619f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(1846f, 1623f, 191f);
			}
			if (HMPOIDIAIMI == 4)
			{
				vector2 = new Vector3(373f, 1398f, 1105f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1505f;
			vector.y = 903f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 72f;
			vector.y = 1457f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 988f;
			vector.y = 1071f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1455f;
			vector.y = 1416f;
		}
		bool flag = FLMFNIGKHKP == -92;
		RaycastHit hitInfo;
		if (Physics.Raycast(NLIGEMDBEOA().transform.position + vector + vector2, JJPEGCHJJED().transform.TransformDirection(Vector3.back), out hitInfo, 156f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(NFANBIICAFM().transform.position + vector + vector2, KEFGHEIOHON().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 24f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(NODPGAOEHGL().transform.position + vector + vector2, DMFKOAIAHDC().transform.TransformDirection(Vector3.back) * 1450f, Color.white, 126f);
		return null;
	}

	private GameObject GCPCLMIKIMI(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1281f, 1003f, 706f);
		Vector3 vector2 = new Vector3(1937f, 1866f, 1031f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1816f, 497f, 1830f);
		}
		if (ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1646f, 252f, 13f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(666f, 1719f, 1869f);
			}
			if (HMPOIDIAIMI == 7)
			{
				vector2 = new Vector3(182f, 1784f, 1184f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1890f;
			vector.y = 148f;
		}
		if (FLMFNIGKHKP == 7)
		{
			vector.x = 379f;
			vector.y = 733f;
		}
		if (FLMFNIGKHKP == 7)
		{
			vector.x = 1489f;
			vector.y = 1215f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1858f;
			vector.y = 243f;
		}
		bool flag = FLMFNIGKHKP != -56;
		RaycastHit hitInfo;
		if (Physics.Raycast(HBDLLAKOFKJ().transform.position + vector + vector2, EICAMMJELIE().transform.TransformDirection(Vector3.back), out hitInfo, 413f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(DMFKOAIAHDC().transform.position + vector + vector2, DMFKOAIAHDC().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 615f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(EICAMMJELIE().transform.position + vector + vector2, playerBase.transform.TransformDirection(Vector3.back) * 1022f, Color.white, 95f);
		return null;
	}

	[SpecialName]
	public PlayerBase DNOKKLIKLAM()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	public int JPDMLANDOOI()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 0)
			{
				currentCombo = currentCombo.OrderBy(DCDDFEHJBNO).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "maps.";
				}
				text = "_Blue_C" + text.Remove(text.Length - 0, 1) + "_BlurRadius4";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf(" or player:" + currentCombo[0].ToString() + "plogs");
		}
		return -1;
	}

	private void ONMGIPAILOH()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[0]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GKLCHNPAEAL(PIHEMHOGGPL[5]) || hardInput.GetKey(PIHEMHOGGPL[7]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.GetKey(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[8]) || hardInput.KFKHHOLEGOK(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.y -= delta.y * AJPABMEPCDO;
				MOFDJECEOBO = false;
			}
			if ((ABINANMGBCE && BDKICAKJKKJ) || (DGLOHIKKOBA && MOFDJECEOBO))
			{
				MPNMOONBMII.z += delta.z * AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, MPNMOONBMII, Time.smoothDeltaTime * lerpSpeed);
		}
		if (isSpectator)
		{
			return;
		}
		foreach (PlayerControllerKeyHandler key2 in keys)
		{
			key2.DPIPGGDNGHN();
		}
		if (isRecording)
		{
			return;
		}
		IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				KeyCode key = (KeyCode)enumerator2.Current;
				if (Input.GetKeyDown(key))
				{
					JJPEGCHJJED().ONOEOGGMDAP(key.ToString());
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = enumerator2 as IDisposable) != null)
			{
				disposable.Dispose();
			}
		}
	}
}
