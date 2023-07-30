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

	public void BIGLPCNFMFA(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.HPKHOICGMFC() == "CameraFilterPack/Vision_Blood" && ((GameScene)Singleton<Scene>.Instance).LBCDKGIFNLN())
			{
				return;
			}
			GameObject gameObject = FFAFNEIDJCC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && DMMGMCGNILI().GetGameScene().gameMode != 0)
				{
					if (OBBDJECLANB().GBHNDHLAJLI().isMine)
					{
						PhotonView photonView = PJFCDBLDDHB().photonView;
						object[] array = new object[0];
						array[0] = false;
						photonView.RPC("FPSToggle", PhotonTargets.AllBuffered, array);
					}
				}
				else
				{
					++KIPGGHFMKLC().incorrectScore;
					NJODHOMKIED().currentCombo = 1;
					if (JDHHBDEAEID && GKGCHBJANLF().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(2, UnityEngine.Random.Range(1688f, 599f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_Value4")
				{
					++DPJHDOFBJLE().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && HEDFKOIPLEM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1926f - FNEPAIOLEOD) <= 1723.0)) ? (648f - FNEPAIOLEOD) : 1824f);
						float max = 1480f + FNEPAIOLEOD;
						if (num <= 1409f)
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min, max));
						}
					}
					GKGCHBJANLF().PHCBHAFMDEJ().RPC("UI Extensions/UISoftAdditive", PhotonTargets.AllBuffered, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 586f;
					num3 = 0f - num2 * num2 / 1824f + 49f;
					if (num3 > 192f)
					{
						num3 = 1228f;
					}
					if (num3 < 1909f)
					{
						num3 = 1184f;
					}
					float num4 = ((!(num3 < 665f)) ? 1688f : ((1381f - num3) * num2 * num2));
					if (num3 >= 1744f)
					{
						++GKGCHBJANLF().perfectHits;
						PlayerBase obj = OBBDJECLANB();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++playerBase.correctScore;
					PlayerBase obj2 = DMMGMCGNILI();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)LMENGPDOOJG().currentCombo;
					PlayerBase obj3 = ICPJINDFDIN();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = KEFGHEIOHON();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)GIGCAEODABJ().accuracyScore) / (float)((int)KIPGGHFMKLC().incorrectScore + (int)HEDFKOIPLEM().correctScore);
					if (JDHHBDEAEID && JDFCILGMEOJ().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1221f - FNEPAIOLEOD) <= 234.0)) ? (1951f - FNEPAIOLEOD) : 939f);
						float max2 = 1651f + FNEPAIOLEOD;
						if (num3 >= 1019f)
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					NJODHOMKIED().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1474f * ((1968f - OMGIMLPPNFI) * 123f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 122 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	public int KNBOIOEKJID()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 0)
			{
				currentCombo = currentCombo.OrderBy(KJIJKMBMOCF).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "ItemNameText";
				}
				text = "Player" + text.Remove(text.Length - 1, 0) + "CameraFilterPack/Blend2Camera_LinearBurn";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 1)
		{
			return Helpers.patternsMap.IndexOf("setAF" + currentCombo[0].ToString() + "_Speed");
		}
		return -1;
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

	public void IPFCGDAKPNE(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.IIPMMNJPGMA() == "GlassesColor" && ((GameScene)Singleton<Scene>.Instance).NCGHKCCPKEI())
			{
				return;
			}
			GameObject gameObject = ADIIPPOIOFM(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && DPJHDOFBJLE().GetGameScene().gameMode != 0)
				{
					if (DFPMJLHLFNK().DJHCJIJAIJP().isMine)
					{
						PhotonView photonView = HEDFKOIPLEM().OELHGNKAMEG();
						object[] array = new object[1];
						array[1] = false;
						photonView.RPC("PLEASE WAIT", PhotonTargets.AllBufferedViaServer, array);
					}
				}
				else
				{
					++HEDFKOIPLEM().incorrectScore;
					IFACNHFOOAM().currentCombo = 1;
					if (JDHHBDEAEID && NABBDBMIHOI().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(1599f, 1979f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "Xbox Home")
				{
					++KIPGGHFMKLC().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1766f - FNEPAIOLEOD) <= 1215.0)) ? (1885f - FNEPAIOLEOD) : 1109f);
						float max = 1838f + FNEPAIOLEOD;
						if (num <= 777f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
					}
					NABBDBMIHOI().GMAHNPNHMFK().RPC("true", PhotonTargets.All, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1583f;
					num3 = 0f - num2 * num2 / 964f + 183f;
					if (num3 > 1550f)
					{
						num3 = 1702f;
					}
					if (num3 < 1190f)
					{
						num3 = 719f;
					}
					float num4 = ((!(num3 < 1297f)) ? 941f : ((259f - num3) * num2 * num2));
					if (num3 >= 705f)
					{
						++ENNCFNJBJAG().perfectHits;
						PlayerBase obj = OBBDJECLANB();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++ICPJINDFDIN().correctScore;
					PlayerBase obj2 = playerBase;
					obj2.comboScore = (float)obj2.comboScore + (float)(int)IDJIIFOLKMG().currentCombo;
					PlayerBase obj3 = JAGBDKPMBGP();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = DPJHDOFBJLE();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)IFACNHFOOAM().accuracyScore) / (float)((int)DMMGMCGNILI().incorrectScore + (int)MEBPHCDCLCC().correctScore);
					if (JDHHBDEAEID && KIPGGHFMKLC().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1219f - FNEPAIOLEOD) <= 503.0)) ? (1741f - FNEPAIOLEOD) : 524f);
						float max2 = 1934f + FNEPAIOLEOD;
						if (num3 >= 1808f)
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					KJHMNOEDBJJ().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1760f * ((683f - OMGIMLPPNFI) * 1388f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -59 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private static int LFMPDJEFBPD(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject NEDKMMJFEGA(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(773f, 1740f, 1990f);
		Vector3 vector2 = new Vector3(1792f, 1522f, 1905f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1483f, 523f, 11f);
		}
		if (ACODLKJMCJF == 4)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(696f, 116f, 1872f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(742f, 241f, 304f);
			}
			if (HMPOIDIAIMI == 5)
			{
				vector2 = new Vector3(774f, 1045f, 1873f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1148f;
			vector.y = 774f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 399f;
			vector.y = 1106f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1466f;
			vector.y = 1545f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1830f;
			vector.y = 36f;
		}
		bool flag = FLMFNIGKHKP == -118;
		RaycastHit hitInfo;
		if (Physics.Raycast(GENOLDKFAPB().transform.position + vector + vector2, JDFCILGMEOJ().transform.TransformDirection(Vector3.back), out hitInfo, 336f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(JAGBDKPMBGP().transform.position + vector + vector2, playerBase.transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1579f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(NJODHOMKIED().transform.position + vector + vector2, FDKFJLHFNMK().transform.TransformDirection(Vector3.back) * 523f, Color.white, 1168f);
		return null;
	}

	[SpecialName]
	public PlayerBase DPJHDOFBJLE()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public void DCJHDJLGEKA(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public PlayerBase HEDFKOIPLEM()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	public int BPJOPJPCKDA()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 0)
			{
				currentCombo = currentCombo.OrderBy(KJIJKMBMOCF).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "masterSteamID";
				}
				text = "_TimeX" + text.Remove(text.Length - 0, 1) + "w";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("runas" + currentCombo[0].ToString() + "[LevelEditorScene] Item creation successful! Published Item ID: ");
		}
		return -1;
	}

	private GameObject ABADLGHAOKO(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(123f, 526f, 286f);
		Vector3 vector2 = new Vector3(317f, 1067f, 481f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(340f, 550f, 1137f);
		}
		if (ACODLKJMCJF == 3)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1915f, 617f, 522f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(716f, 30f, 728f);
			}
			if (HMPOIDIAIMI == 5)
			{
				vector2 = new Vector3(538f, 244f, 396f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 898f;
			vector.y = 1502f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 784f;
			vector.y = 1857f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 1680f;
			vector.y = 867f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1220f;
			vector.y = 562f;
		}
		bool flag = FLMFNIGKHKP != -4;
		RaycastHit hitInfo;
		if (Physics.Raycast(KIPGGHFMKLC().transform.position + vector + vector2, NJODHOMKIED().transform.TransformDirection(Vector3.back), out hitInfo, 689f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(MEBPHCDCLCC().transform.position + vector + vector2, PJFCDBLDDHB().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 172f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(GIGCAEODABJ().transform.position + vector + vector2, KEFGHEIOHON().transform.TransformDirection(Vector3.back) * 279f, Color.white, 1945f);
		return null;
	}

	private static int PJAEKOEGHDM(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private void BMOFEBKGLFI()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().BBGIDKNEGHD().isMine)
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				DCJHDJLGEKA(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = JAGBDKPMBGP().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[4], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[7], 7, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[4], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[2], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)6, PIHEMHOGGPL[-50], 8, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.DPAGLGGNECO("violet", 1100f);
			if (Singleton<Scene>.Instance.PAGFNJCJFGL() == "HostType: {0} ")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.GetInt("y", 1) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && Singleton<SaveSystem>.Instance.KFNFNKILGPH("_TimeX", 1) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.DPAGLGGNECO("_Value", 1253f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("attempted to spawn a GameObject from recycle bin (", 63f);
		}
	}

	public void PHDABEGNCON(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.OOFJKHEJJNM() == "CameraFilterPack/EXTRA_Rotation" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = FJNCPEAMEHC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && GKGCHBJANLF().GetGameScene().gameMode != 0)
				{
					if (KJHMNOEDBJJ().IBKCMBIGOEJ().isMine)
					{
						PhotonView photonView = ENNCFNJBJAG().OELHGNKAMEG();
						object[] array = new object[0];
						array[0] = true;
						photonView.RPC("_ScreenResolution", (PhotonTargets)8, array);
					}
				}
				else
				{
					++KIPGGHFMKLC().incorrectScore;
					JHEFABODNPO().currentCombo = 0;
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.DMOMDMCBBFI(3, UnityEngine.Random.Range(892f, 975f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "SupportLogger OnLeftRoom().")
				{
					++PJFCDBLDDHB().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && JHEFABODNPO().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1900f - FNEPAIOLEOD) <= 484.0)) ? (1937f - FNEPAIOLEOD) : 1700f);
						float max = 628f + FNEPAIOLEOD;
						if (num <= 760f)
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min, max));
						}
					}
					FDKFJLHFNMK().EOOCGIFFKBG().RPC(", ", PhotonTargets.Others, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 57f;
					num3 = 0f - num2 * num2 / 1994f + 446f;
					if (num3 > 510f)
					{
						num3 = 985f;
					}
					if (num3 < 517f)
					{
						num3 = 1968f;
					}
					float num4 = ((!(num3 < 532f)) ? 1911f : ((1180f - num3) * num2 * num2));
					if (num3 >= 401f)
					{
						++GENOLDKFAPB().perfectHits;
						PlayerBase obj = FDKFJLHFNMK();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++KJHMNOEDBJJ().correctScore;
					PlayerBase obj2 = EICAMMJELIE();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)FBMHDALMKAL().currentCombo;
					PlayerBase obj3 = KIPGGHFMKLC();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = KJHMNOEDBJJ();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)LMENGPDOOJG().accuracyScore) / (float)((int)HEDFKOIPLEM().incorrectScore + (int)FDKFJLHFNMK().correctScore);
					if (JDHHBDEAEID && JFINMCMCFIL().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1895f - FNEPAIOLEOD) <= 1638.0)) ? (1812f - FNEPAIOLEOD) : 1766f);
						float max2 = 1914f + FNEPAIOLEOD;
						if (num3 >= 1926f)
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					DMMGMCGNILI().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 529f * ((1521f - OMGIMLPPNFI) * 1083f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 6 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private static int GAAIAJFFFBH(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject ANFBEGDLNPI(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1311f, 1475f, 762f);
		Vector3 vector2 = new Vector3(1596f, 627f, 171f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(820f, 1647f, 441f);
		}
		if (ACODLKJMCJF == 1)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(497f, 638f, 1991f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(545f, 864f, 1467f);
			}
			if (HMPOIDIAIMI == 5)
			{
				vector2 = new Vector3(1515f, 548f, 663f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 447f;
			vector.y = 1640f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 1350f;
			vector.y = 1645f;
		}
		if (FLMFNIGKHKP == 8)
		{
			vector.x = 1918f;
			vector.y = 1284f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1676f;
			vector.y = 1650f;
		}
		bool flag = FLMFNIGKHKP == -82;
		RaycastHit hitInfo;
		if (Physics.Raycast(NJODHOMKIED().transform.position + vector + vector2, EICAMMJELIE().transform.TransformDirection(Vector3.back), out hitInfo, 95f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(GIGCAEODABJ().transform.position + vector + vector2, OBBDJECLANB().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 949f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(JDFCILGMEOJ().transform.position + vector + vector2, FBMHDALMKAL().transform.TransformDirection(Vector3.back) * 847f, Color.white, 206f);
		return null;
	}

	private static int DFDNLNBJFBC(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private void LPMINJJPDCH()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[0]) || hardInput.GetKey(PIHEMHOGGPL[0]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[2]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[0]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[8]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[8]))
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
			key2.KIEJKBNBHMD();
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
					KIPGGHFMKLC().RecordAction(key.ToString());
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
	public PlayerBase GENOLDKFAPB()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void MJEFMIPLFAB()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().BBGIDKNEGHD().isMine)
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				FHPNGAEOHKE(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = playerBase.fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[2], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[7], 7, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[5], 3, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[2], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[-42], 8, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.DPAGLGGNECO("player.currentrank", 1371f);
			if (Singleton<Scene>.Instance.DINKBGAFKAH() == "LeaderboardsButton")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.HHBIEPMBICO("_MidGrey", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.GetInt("]", 1) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.PGKJAIODCEF("_Intensity", 1071f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("CameraFilterPack/Glasses_On", 421f);
		}
	}

	[SpecialName]
	public bool IIPFGMDOEDF()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public PlayerBase KJHMNOEDBJJ()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private GameObject DELNANDJNKP(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1066f, 586f, 539f);
		Vector3 vector2 = new Vector3(1862f, 344f, 1339f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1628f, 585f, 885f);
		}
		if (ACODLKJMCJF == 8)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(778f, 1827f, 1656f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(1436f, 488f, 408f);
			}
			if (HMPOIDIAIMI == 8)
			{
				vector2 = new Vector3(345f, 1107f, 1114f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 611f;
			vector.y = 1961f;
		}
		if (FLMFNIGKHKP == 2)
		{
			vector.x = 1479f;
			vector.y = 865f;
		}
		if (FLMFNIGKHKP == 8)
		{
			vector.x = 1038f;
			vector.y = 402f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 563f;
			vector.y = 1352f;
		}
		bool flag = FLMFNIGKHKP != -89;
		RaycastHit hitInfo;
		if (Physics.Raycast(DPJHDOFBJLE().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back), out hitInfo, 1178f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(JHEFABODNPO().transform.position + vector + vector2, MEBPHCDCLCC().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 279f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(KIPGGHFMKLC().transform.position + vector + vector2, FBMHDALMKAL().transform.TransformDirection(Vector3.back) * 1160f, Color.white, 1205f);
		return null;
	}

	[SpecialName]
	public bool CDFOGOEFHIF()
	{
		return JDHHBDEAEID;
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

	private static int DIAKHNNKBOE(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	[SpecialName]
	public void CCAJKDKGGHH(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public PlayerBase KIPGGHFMKLC()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	public void GCPKNBBPAHJ(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.DINKBGAFKAH() == "z" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = MCJMKBKADEO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && NJODHOMKIED().GetGameScene().gameMode != 0)
				{
					if (FBMHDALMKAL().IBKCMBIGOEJ().isMine)
					{
						PhotonView photonView = IFACNHFOOAM().JAEJDHHCJJO();
						object[] array = new object[0];
						array[0] = false;
						photonView.RPC("[PlayerController] ", PhotonTargets.All, array);
					}
				}
				else
				{
					++GENOLDKFAPB().incorrectScore;
					GKGCHBJANLF().currentCombo = 1;
					if (JDHHBDEAEID && ENNCFNJBJAG().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.DMOMDMCBBFI(3, UnityEngine.Random.Range(561f, 697f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_ScreenResolution")
				{
					++FBMHDALMKAL().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(468f - FNEPAIOLEOD) <= 242.0)) ? (1566f - FNEPAIOLEOD) : 704f);
						float max = 539f + FNEPAIOLEOD;
						if (num <= 888f)
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					JDFCILGMEOJ().IFENGKHOKPC().RPC("inventory.selected.", PhotonTargets.All, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1307f;
					num3 = 0f - num2 * num2 / 748f + 1192f;
					if (num3 > 39f)
					{
						num3 = 1021f;
					}
					if (num3 < 432f)
					{
						num3 = 855f;
					}
					float num4 = ((!(num3 < 1860f)) ? 304f : ((716f - num3) * num2 * num2));
					if (num3 >= 1236f)
					{
						++GIGCAEODABJ().perfectHits;
						PlayerBase obj = JFINMCMCFIL();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++DPJHDOFBJLE().correctScore;
					PlayerBase obj2 = ICPJINDFDIN();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)JAGBDKPMBGP().currentCombo;
					PlayerBase obj3 = playerBase;
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = NABBDBMIHOI();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)JDFCILGMEOJ().accuracyScore) / (float)((int)HEDFKOIPLEM().incorrectScore + (int)FDKFJLHFNMK().correctScore);
					if (JDHHBDEAEID && JAGBDKPMBGP().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1040f - FNEPAIOLEOD) <= 1739.0)) ? (1326f - FNEPAIOLEOD) : 1380f);
						float max2 = 1015f + FNEPAIOLEOD;
						if (num3 >= 1629f)
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					ICPJINDFDIN().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1363f * ((1841f - OMGIMLPPNFI) * 1497f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 101 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	[SpecialName]
	public PlayerBase JDFCILGMEOJ()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void LLJLDLLNFBH()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = true;
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[1]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[4]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[1]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[1]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[4]))
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
			key2.CGBHOELMAOC();
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
					JFINMCMCFIL().RecordAction(key.ToString());
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

	public int GPBFAEIADJD()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 0)
			{
				currentCombo = currentCombo.OrderBy((Direction HPHENPOHOMK) => (int)HPHENPOHOMK).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "PossibleMapPointsText";
				}
				text = "{\"items\":" + text.Remove(text.Length - 1, 1) + ". Prefab must have a PhotonView component.";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("settings.gamemessagesduration" + currentCombo[0].ToString() + "_ScreenResolution");
		}
		return -1;
	}

	public int FFHJBOCNMMA()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(LFMPDJEFBPD).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "LevelURLInputField";
				}
				text = "[Up]" + text.Remove(text.Length - 1, 1) + "#close";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("{0:0} minute{1}, " + currentCombo[1].ToString() + "inventory.itemscash");
		}
		return -1;
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

	[SpecialName]
	public bool HNGEAFIJFIN()
	{
		return JDHHBDEAEID;
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

	private void OIBMHPIFAKK()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = true;
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[0]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[2]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[7]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[0]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[0]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[2]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[5]))
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
			key2.BMODOIJGIOO();
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
					FBMHDALMKAL().IABCMJMLPPP(key.ToString());
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
	public void PCEPJKNBGHA(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public PlayerBase NABBDBMIHOI()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void LCJHDLKJEOM()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = false;
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[7]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[4]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[6]))
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
			key2.OCMKCBBCEFG();
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
					DMMGMCGNILI().IABCMJMLPPP(key.ToString());
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

	private void COOHIILCOCO()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().GBMJAPGLMGB().isMine)
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				playerBase = GetComponentInParent<PlayerBase>();
				ACODLKJMCJF = DPJHDOFBJLE().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[3], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[2], 4, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 5, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[6], 4, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[4], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[-10], 7, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("[SERVER] Selected map: ", 1391f);
			if (Singleton<Scene>.Instance.ABCDALKLGBH() == "BadgeText")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.KFNFNKILGPH("USE_DIAG_SEARCH", 1) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && Singleton<SaveSystem>.Instance.HHBIEPMBICO("settings.gamemessagesduration", 1) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.PGKJAIODCEF(" Gb", 505f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.DPAGLGGNECO("VisionBlur", 707f);
		}
	}

	[SpecialName]
	public void FHPNGAEOHKE(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public void MCGBMDAPBJP(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	private static int PDNBCEJFJGN(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject BJOPCPAGIDO(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1798f, 1027f, 1562f);
		Vector3 vector2 = new Vector3(1646f, 815f, 161f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1101f, 1807f, 967f);
		}
		if (ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1138f, 12f, 1685f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(1760f, 849f, 1257f);
			}
			if (HMPOIDIAIMI == 6)
			{
				vector2 = new Vector3(191f, 603f, 1609f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 196f;
			vector.y = 101f;
		}
		if (FLMFNIGKHKP == 8)
		{
			vector.x = 481f;
			vector.y = 1018f;
		}
		if (FLMFNIGKHKP == 7)
		{
			vector.x = 1553f;
			vector.y = 1450f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 673f;
			vector.y = 1998f;
		}
		bool flag = FLMFNIGKHKP == -73;
		RaycastHit hitInfo;
		if (Physics.Raycast(ICPJINDFDIN().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back), out hitInfo, 937f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(GKGCHBJANLF().transform.position + vector + vector2, GKGCHBJANLF().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 432f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(JDFCILGMEOJ().transform.position + vector + vector2, LMENGPDOOJG().transform.TransformDirection(Vector3.back) * 1358f, Color.white, 116f);
		return null;
	}

	[SpecialName]
	public void ALFOKGJDJAG(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public bool GAAFFCDPALM()
	{
		return JDHHBDEAEID;
	}

	private void ODBNMPGBCGO()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().GBHNDHLAJLI().isMine)
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				PCEPJKNBGHA(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = playerBase.fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[3], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[3], 7, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[2], 6, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[0], 6, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[1], 5, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[37], 7, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.DPAGLGGNECO("Cant send PickupItem spawn times to unknown targetPlayer.", 1749f);
			if (Singleton<Scene>.Instance.ABCDALKLGBH() == "PunPickupSimple")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.HHBIEPMBICO("_TimeX", 1) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && Singleton<SaveSystem>.Instance.HHBIEPMBICO("[ReplayScene] Loading replay: ", 1) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.HCNELAJLBPC("Jan", 1087f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.DPAGLGGNECO("CameraFilterPack/Vision_Blood", 1242f);
		}
	}

	[SpecialName]
	public PlayerBase PJFCDBLDDHB()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void DNNFHBOOPIN()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().CIACEFBNDDJ().isMine)
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				EACLLKIGDOG(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = EICAMMJELIE().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[1], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[2], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[4], 7, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[7], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[2], 5, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Down, PIHEMHOGGPL[111], 6, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.PGKJAIODCEF("PublishButton", 139f);
			if (Singleton<Scene>.Instance.PDKEOLKBKAA() == "_Value5")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.HHBIEPMBICO("GlassColor", 1) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.KFNFNKILGPH("#lives", 0) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.HCNELAJLBPC("_TimeX", 1650f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.HCNELAJLBPC("CameraFilterPack/Blur_Blurry", 1959f);
		}
	}

	public int CNLDGEMKLPP()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(LFMPDJEFBPD).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "G:";
				}
				text = "_Convolved_TexelSize" + text.Remove(text.Length - 1, 0) + "<b>#";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 1)
		{
			return Helpers.patternsMap.IndexOf("-1" + currentCombo[1].ToString() + "ScreenResolutionPanel");
		}
		return -1;
	}

	[SpecialName]
	public void GFAAIOBADNN(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	private void POIMNOBDBBN()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[0]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[5]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[8]))
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
			key2.BMODOIJGIOO();
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
					DMMGMCGNILI().RecordAction(key.ToString());
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

	private void DOKAKEMDALN()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().BBGIDKNEGHD().isMine)
			{
				isSpectator = false;
				GetComponentInChildren<Camera>().enabled = true;
				GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				playerBase = GetComponentInParent<PlayerBase>();
				ACODLKJMCJF = FBMHDALMKAL().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[6], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[3], 8, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 5, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[8], 5, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[3], 2, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)5, PIHEMHOGGPL[25], 5, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.HCNELAJLBPC("CameraFilterPack/Drawing_Manga_Flash_Color", 957f);
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "st")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.KFNFNKILGPH("mapselector.filter.subscribedonly", 0) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || (Singleton<SaveSystem>.Instance.KFNFNKILGPH("_BlurVector", 0) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.PGKJAIODCEF("CameraFilterPack/Blend2Camera_PinLight", 1714f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.PGKJAIODCEF("ScreenResolutionPanel", 692f);
		}
	}

	private void KNBJBNDGCIJ()
	{
		if (!isRecording)
		{
			if ((bool)GetComponentInParent<PlayerBase>() && !GetComponentInParent<PlayerBase>().GBMJAPGLMGB().isMine)
			{
				isSpectator = true;
				GetComponentInChildren<Camera>().enabled = false;
				GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				EACLLKIGDOG(GetComponentInParent<PlayerBase>());
				ACODLKJMCJF = FBMHDALMKAL().fullLevelData.mapData.handCount;
			}
		}
		keys.Clear();
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[0], 1, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[0], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[1], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Right, PIHEMHOGGPL[8], 3, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Up, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.PowerUp, PIHEMHOGGPL[7], 3, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)8, PIHEMHOGGPL[2], 0, this));
		keys.Add(new PlayerControllerKeyHandler((Direction)7, PIHEMHOGGPL[8], 0, this));
		keys.Add(new PlayerControllerKeyHandler(Direction.Left, PIHEMHOGGPL[106], 4, this));
		if (!isRecording)
		{
			JDAPEMPBJKM = base.transform.localPosition;
			AJPABMEPCDO = Singleton<SaveSystem>.Instance.PGKJAIODCEF("ShowTitle", 1407f);
			if (Singleton<Scene>.Instance.JABENKBHJGE() == "/")
			{
				JDHHBDEAEID = (Singleton<SaveSystem>.Instance.HHBIEPMBICO("_Near", 0) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != 0) || Singleton<SaveSystem>.Instance.GetInt(" : ", 1) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax;
			}
			FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("Remove Environment Object", 1449f);
			OMGIMLPPNFI = Singleton<SaveSystem>.Instance.HCNELAJLBPC("CameraFilterPack/3D_Anomaly", 1359f);
		}
	}

	public void GPCPPDDHDAG(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.id == "CameraFilterPack/Blend2Camera_Subtract" && ((GameScene)Singleton<Scene>.Instance).MJOLOHPNJDK())
			{
				return;
			}
			GameObject gameObject = FJNCPEAMEHC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && IFACNHFOOAM().GetGameScene().gameMode != 0)
				{
					if (KIPGGHFMKLC().NABDKNPNEMM().isMine)
					{
						PhotonView photonView = LMENGPDOOJG().AAMNKPHHHCI();
						object[] array = new object[0];
						array[0] = false;
						photonView.RPC("#ok", PhotonTargets.OthersBuffered, array);
					}
				}
				else
				{
					++IFACNHFOOAM().incorrectScore;
					NJODHOMKIED().currentCombo = 0;
					if (JDHHBDEAEID && EICAMMJELIE().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(2, UnityEngine.Random.Range(1218f, 1286f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_Distortion")
				{
					++JHEFABODNPO().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && KIPGGHFMKLC().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1101f - FNEPAIOLEOD) <= 1838.0)) ? (263f - FNEPAIOLEOD) : 1260f);
						float max = 391f + FNEPAIOLEOD;
						if (num <= 1540f)
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min, max));
						}
					}
					GIGCAEODABJ().PHCBHAFMDEJ().RPC("TBD", PhotonTargets.AllBufferedViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 619f;
					num3 = 0f - num2 * num2 / 1645f + 1103f;
					if (num3 > 1132f)
					{
						num3 = 574f;
					}
					if (num3 < 1422f)
					{
						num3 = 1781f;
					}
					float num4 = ((!(num3 < 732f)) ? 1914f : ((1801f - num3) * num2 * num2));
					if (num3 >= 555f)
					{
						++JAGBDKPMBGP().perfectHits;
						PlayerBase obj = LMENGPDOOJG();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++playerBase.correctScore;
					PlayerBase obj2 = KJHMNOEDBJJ();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)KIPGGHFMKLC().currentCombo;
					PlayerBase obj3 = DFPMJLHLFNK();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = HEDFKOIPLEM();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)EICAMMJELIE().accuracyScore) / (float)((int)GENOLDKFAPB().incorrectScore + (int)NABBDBMIHOI().correctScore);
					if (JDHHBDEAEID && GIGCAEODABJ().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1105f - FNEPAIOLEOD) <= 1203.0)) ? (1662f - FNEPAIOLEOD) : 1047f);
						float max2 = 1691f + FNEPAIOLEOD;
						if (num3 >= 1083f)
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					JFINMCMCFIL().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 173f * ((1632f - OMGIMLPPNFI) * 4f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.IGBBPLOFEKG(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -110 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	public int ALKGJEEHEBN()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(DFDNLNBJFBC).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "steamid";
				}
				text = "_EmissionColor" + text.Remove(text.Length - 0, 0) + "_ReflectionTexture3";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 1)
		{
			return Helpers.patternsMap.IndexOf(" isInactive: " + currentCombo[1].ToString() + ".lastCheckpoint.time");
		}
		return -1;
	}

	[SpecialName]
	public bool EOHHBJFNOON()
	{
		return JDHHBDEAEID;
	}

	private static int AJAJEKAJNBC(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
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

	private void HLDFOJMHKNL()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = false;
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[1]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[5]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[0]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[7]) || hardInput.GetKey(PIHEMHOGGPL[5]))
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
			key2.JOACBIEHHCE();
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
					IFACNHFOOAM().IABCMJMLPPP(key.ToString());
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

	private GameObject FMOHBPMDAOK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1247f, 1016f, 71f);
		Vector3 vector2 = new Vector3(657f, 1676f, 1950f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1463f, 642f, 733f);
		}
		if (ACODLKJMCJF == 5)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(496f, 826f, 407f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(545f, 1455f, 425f);
			}
			if (HMPOIDIAIMI == 2)
			{
				vector2 = new Vector3(1298f, 808f, 1469f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 593f;
			vector.y = 1588f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 567f;
			vector.y = 892f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 1873f;
			vector.y = 1751f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1256f;
			vector.y = 655f;
		}
		bool flag = FLMFNIGKHKP == 67;
		RaycastHit hitInfo;
		if (Physics.Raycast(DMMGMCGNILI().transform.position + vector + vector2, KJHMNOEDBJJ().transform.TransformDirection(Vector3.back), out hitInfo, 209f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(KEFGHEIOHON().transform.position + vector + vector2, NABBDBMIHOI().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 823f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(GIGCAEODABJ().transform.position + vector + vector2, PJFCDBLDDHB().transform.TransformDirection(Vector3.back) * 811f, Color.white, 915f);
		return null;
	}

	public void GFGHHDOBFEJ(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.PHCHLPBPKHL() == "SetEnvSpriteImage" && ((GameScene)Singleton<Scene>.Instance).LBCDKGIFNLN())
			{
				return;
			}
			GameObject gameObject = MCJMKBKADEO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && GIGCAEODABJ().GetGameScene().gameMode != 0)
				{
					if (playerBase.CIACEFBNDDJ().isMine)
					{
						PhotonView photonView = ICPJINDFDIN().ACPGHFHDCIP();
						object[] array = new object[0];
						array[1] = false;
						photonView.RPC("_FixDistance", (PhotonTargets)7, array);
					}
				}
				else
				{
					++JHEFABODNPO().incorrectScore;
					GKGCHBJANLF().currentCombo = 1;
					if (JDHHBDEAEID && GKGCHBJANLF().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.DMOMDMCBBFI(3, UnityEngine.Random.Range(371f, 1078f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "PlayButton")
				{
					++JHEFABODNPO().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && DFPMJLHLFNK().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(882f - FNEPAIOLEOD) <= 83.0)) ? (486f - FNEPAIOLEOD) : 1093f);
						float max = 386f + FNEPAIOLEOD;
						if (num <= 1954f)
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min, max));
						}
					}
					GIGCAEODABJ().DJHCJIJAIJP().RPC("_TimeX", PhotonTargets.MasterClient, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1488f;
					num3 = 0f - num2 * num2 / 414f + 731f;
					if (num3 > 1804f)
					{
						num3 = 97f;
					}
					if (num3 < 1442f)
					{
						num3 = 1738f;
					}
					float num4 = ((!(num3 < 69f)) ? 1569f : ((1849f - num3) * num2 * num2));
					if (num3 >= 1719f)
					{
						++FBMHDALMKAL().perfectHits;
						PlayerBase obj = NJODHOMKIED();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++IDJIIFOLKMG().correctScore;
					PlayerBase obj2 = PJFCDBLDDHB();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)NABBDBMIHOI().currentCombo;
					PlayerBase obj3 = KIPGGHFMKLC();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = HEDFKOIPLEM();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)NJODHOMKIED().accuracyScore) / (float)((int)EICAMMJELIE().incorrectScore + (int)DPJHDOFBJLE().correctScore);
					if (JDHHBDEAEID && ENNCFNJBJAG().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1208f - FNEPAIOLEOD) <= 129.0)) ? (1969f - FNEPAIOLEOD) : 1300f);
						float max2 = 852f + FNEPAIOLEOD;
						if (num3 >= 8f)
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					EICAMMJELIE().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1015f * ((1604f - OMGIMLPPNFI) * 319f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 10 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private void IKIDIJLIGOH()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[1]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[0]) || hardInput.GetKey(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[0]))
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
			key2.LPMINJJPDCH();
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
					HEDFKOIPLEM().OEELENKFCOM(key.ToString());
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

	private static int AEEHMJNOPNE(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	public void JOAEFBPDEJP(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "music" && ((GameScene)Singleton<Scene>.Instance).LBCDKGIFNLN())
			{
				return;
			}
			GameObject gameObject = NEDKMMJFEGA(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && IDJIIFOLKMG().GetGameScene().gameMode != 0)
				{
					if (KEFGHEIOHON().DJHCJIJAIJP().isMine)
					{
						PhotonView photonView = ICPJINDFDIN().CIACEFBNDDJ();
						object[] array = new object[0];
						array[0] = true;
						photonView.RPC("_TimeX", (PhotonTargets)8, array);
					}
				}
				else
				{
					++IFACNHFOOAM().incorrectScore;
					ICPJINDFDIN().currentCombo = 0;
					if (JDHHBDEAEID && JHEFABODNPO().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(1935f, 693f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_Metrics")
				{
					++PJFCDBLDDHB().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && FBMHDALMKAL().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1702f - FNEPAIOLEOD) <= 778.0)) ? (1851f - FNEPAIOLEOD) : 1420f);
						float max = 902f + FNEPAIOLEOD;
						if (num <= 1964f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
					}
					ENNCFNJBJAG().CIACEFBNDDJ().RPC("GlassDistortion", PhotonTargets.Others, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 59f;
					num3 = 0f - num2 * num2 / 395f + 916f;
					if (num3 > 1485f)
					{
						num3 = 664f;
					}
					if (num3 < 95f)
					{
						num3 = 453f;
					}
					float num4 = ((!(num3 < 89f)) ? 68f : ((888f - num3) * num2 * num2));
					if (num3 >= 1678f)
					{
						++KJHMNOEDBJJ().perfectHits;
						PlayerBase obj = HEDFKOIPLEM();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++KEFGHEIOHON().correctScore;
					PlayerBase obj2 = HEDFKOIPLEM();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)DPJHDOFBJLE().currentCombo;
					PlayerBase obj3 = JHEFABODNPO();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = OBBDJECLANB();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)DFPMJLHLFNK().accuracyScore) / (float)((int)JAGBDKPMBGP().incorrectScore + (int)FDKFJLHFNMK().correctScore);
					if (JDHHBDEAEID && ENNCFNJBJAG().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(503f - FNEPAIOLEOD) <= 1834.0)) ? (1617f - FNEPAIOLEOD) : 542f);
						float max2 = 1477f + FNEPAIOLEOD;
						if (num3 >= 1651f)
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					EICAMMJELIE().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1302f * ((558f - OMGIMLPPNFI) * 1465f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.IGBBPLOFEKG(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -23 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	public void KIPNNNAHGDJ(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.HNGIHCKINDJ() == "settings.cameramovements" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = FMOHBPMDAOK(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && ENNCFNJBJAG().GetGameScene().gameMode != 0)
				{
					if (JAGBDKPMBGP().EOOCGIFFKBG().isMine)
					{
						PhotonView photonView = GENOLDKFAPB().GMAHNPNHMFK();
						object[] array = new object[1];
						array[1] = true;
						photonView.RPC("0 seconds", PhotonTargets.All, array);
					}
				}
				else
				{
					++ICPJINDFDIN().incorrectScore;
					DPJHDOFBJLE().currentCombo = 0;
					if (JDHHBDEAEID && KJHMNOEDBJJ().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(5, UnityEngine.Random.Range(1093f, 155f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "[NetworkManager] roomInfo.name: ")
				{
					++IDJIIFOLKMG().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && IFACNHFOOAM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(543f - FNEPAIOLEOD) <= 1199.0)) ? (1796f - FNEPAIOLEOD) : 1558f);
						float max = 107f + FNEPAIOLEOD;
						if (num <= 696f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min, max));
						}
					}
					GENOLDKFAPB().BLMHOKPIMOD().RPC("ScreenResolutionPanel", PhotonTargets.AllViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1786f;
					num3 = 0f - num2 * num2 / 1488f + 332f;
					if (num3 > 1014f)
					{
						num3 = 246f;
					}
					if (num3 < 699f)
					{
						num3 = 77f;
					}
					float num4 = ((!(num3 < 615f)) ? 897f : ((430f - num3) * num2 * num2));
					if (num3 >= 698f)
					{
						++KIPGGHFMKLC().perfectHits;
						PlayerBase obj = KIPGGHFMKLC();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++HEDFKOIPLEM().correctScore;
					PlayerBase obj2 = JFINMCMCFIL();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)GKGCHBJANLF().currentCombo;
					PlayerBase obj3 = JHEFABODNPO();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = KJHMNOEDBJJ();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)GENOLDKFAPB().accuracyScore) / (float)((int)FDKFJLHFNMK().incorrectScore + (int)JAGBDKPMBGP().correctScore);
					if (JDHHBDEAEID && GKGCHBJANLF().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(513f - FNEPAIOLEOD) <= 88.0)) ? (1939f - FNEPAIOLEOD) : 503f);
						float max2 = 1848f + FNEPAIOLEOD;
						if (num3 >= 1733f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					MEBPHCDCLCC().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1550f * ((1203f - OMGIMLPPNFI) * 676f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -110 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private GameObject LDBDONOAJLN(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1804f, 1997f, 62f);
		Vector3 vector2 = new Vector3(824f, 119f, 226f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(537f, 291f, 421f);
		}
		if (ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1004f, 250f, 15f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(585f, 1538f, 111f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(665f, 615f, 1567f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1918f;
			vector.y = 1692f;
		}
		if (FLMFNIGKHKP == 8)
		{
			vector.x = 1301f;
			vector.y = 767f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 734f;
			vector.y = 897f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 704f;
			vector.y = 1373f;
		}
		bool flag = FLMFNIGKHKP == 26;
		RaycastHit hitInfo;
		if (Physics.Raycast(LMENGPDOOJG().transform.position + vector + vector2, playerBase.transform.TransformDirection(Vector3.back), out hitInfo, 1240f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(MEBPHCDCLCC().transform.position + vector + vector2, GENOLDKFAPB().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1684f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(JFINMCMCFIL().transform.position + vector + vector2, ENNCFNJBJAG().transform.TransformDirection(Vector3.back) * 1639f, Color.white, 393f);
		return null;
	}

	[SpecialName]
	public PlayerBase GKGCHBJANLF()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public PlayerBase ICPJINDFDIN()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	public void POFBCEKBIDH(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.CNEOMFHNLOD() == ": " && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = DDJOAANAMHL(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && playerBase.GetGameScene().gameMode != 0)
				{
					if (GIGCAEODABJ().AAMNKPHHHCI().isMine)
					{
						PhotonView photonView = JAGBDKPMBGP().JAEJDHHCJJO();
						object[] array = new object[1];
						array[1] = false;
						photonView.RPC("_Value", PhotonTargets.AllBufferedViaServer, array);
					}
				}
				else
				{
					++DFPMJLHLFNK().incorrectScore;
					PJFCDBLDDHB().currentCombo = 0;
					if (JDHHBDEAEID && EICAMMJELIE().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(1722f, 474f));
					}
				}
			}
			else
			{
				if (gameObject.tag == " ")
				{
					++DPJHDOFBJLE().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && NABBDBMIHOI().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(480f - FNEPAIOLEOD) <= 848.0)) ? (1550f - FNEPAIOLEOD) : 1635f);
						float max = 975f + FNEPAIOLEOD;
						if (num <= 1715f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					MEBPHCDCLCC().GBHNDHLAJLI().RPC("menutheme.deleted", (PhotonTargets)8, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1722f;
					num3 = 0f - num2 * num2 / 129f + 273f;
					if (num3 > 835f)
					{
						num3 = 328f;
					}
					if (num3 < 1453f)
					{
						num3 = 1540f;
					}
					float num4 = ((!(num3 < 1426f)) ? 201f : ((440f - num3) * num2 * num2));
					if (num3 >= 1574f)
					{
						++IFACNHFOOAM().perfectHits;
						PlayerBase obj = JFINMCMCFIL();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++HEDFKOIPLEM().correctScore;
					PlayerBase obj2 = ICPJINDFDIN();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)JHEFABODNPO().currentCombo;
					PlayerBase obj3 = IDJIIFOLKMG();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = HEDFKOIPLEM();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)EICAMMJELIE().accuracyScore) / (float)((int)playerBase.incorrectScore + (int)DFPMJLHLFNK().correctScore);
					if (JDHHBDEAEID && GIGCAEODABJ().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(961f - FNEPAIOLEOD) <= 126.0)) ? (605f - FNEPAIOLEOD) : 890f);
						float max2 = 1492f + FNEPAIOLEOD;
						if (num3 >= 407f)
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					JHEFABODNPO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 404f * ((591f - OMGIMLPPNFI) * 245f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.IGBBPLOFEKG(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -18 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private GameObject MCJMKBKADEO(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1679f, 1932f, 1953f);
		Vector3 vector2 = new Vector3(1701f, 131f, 526f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(27f, 1534f, 1733f);
		}
		if (ACODLKJMCJF == 3)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1648f, 188f, 21f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(678f, 508f, 521f);
			}
			if (HMPOIDIAIMI == 4)
			{
				vector2 = new Vector3(1183f, 1974f, 1583f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1078f;
			vector.y = 1675f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1986f;
			vector.y = 828f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1593f;
			vector.y = 1529f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 106f;
			vector.y = 830f;
		}
		bool flag = FLMFNIGKHKP != 18;
		RaycastHit hitInfo;
		if (Physics.Raycast(JFINMCMCFIL().transform.position + vector + vector2, DFPMJLHLFNK().transform.TransformDirection(Vector3.back), out hitInfo, 899f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(ENNCFNJBJAG().transform.position + vector + vector2, PJFCDBLDDHB().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1054f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(GENOLDKFAPB().transform.position + vector + vector2, JHEFABODNPO().transform.TransformDirection(Vector3.back) * 905f, Color.white, 367f);
		return null;
	}

	[SpecialName]
	public PlayerBase FDKFJLHFNMK()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public void BBBKFFFDCAJ(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public PlayerBase LMENGPDOOJG()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public void IGOMIDKILBN(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	private static int INIHCMBNHOL(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject NDMJEPJAMBH(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(62f, 1586f, 1061f);
		Vector3 vector2 = new Vector3(349f, 587f, 1295f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(1658f, 1563f, 1837f);
		}
		if (ACODLKJMCJF == 3)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1949f, 1963f, 969f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1083f, 1389f, 1633f);
			}
			if (HMPOIDIAIMI == 6)
			{
				vector2 = new Vector3(1475f, 1946f, 1917f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1349f;
			vector.y = 673f;
		}
		if (FLMFNIGKHKP == 4)
		{
			vector.x = 1338f;
			vector.y = 573f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 1808f;
			vector.y = 1121f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1563f;
			vector.y = 1431f;
		}
		bool flag = FLMFNIGKHKP != -29;
		RaycastHit hitInfo;
		if (Physics.Raycast(DMMGMCGNILI().transform.position + vector + vector2, IFACNHFOOAM().transform.TransformDirection(Vector3.back), out hitInfo, 1830f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(DMMGMCGNILI().transform.position + vector + vector2, KIPGGHFMKLC().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1920f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(EICAMMJELIE().transform.position + vector + vector2, MEBPHCDCLCC().transform.TransformDirection(Vector3.back) * 903f, Color.white, 293f);
		return null;
	}

	private GameObject DDJOAANAMHL(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(707f, 1992f, 1078f);
		Vector3 vector2 = new Vector3(151f, 1024f, 1472f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(923f, 60f, 1002f);
		}
		if (ACODLKJMCJF == 4)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1635f, 1824f, 395f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(531f, 1221f, 995f);
			}
			if (HMPOIDIAIMI == 2)
			{
				vector2 = new Vector3(1300f, 1779f, 1883f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1873f;
			vector.y = 1291f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 368f;
			vector.y = 1466f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 443f;
			vector.y = 1654f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1624f;
			vector.y = 602f;
		}
		bool flag = FLMFNIGKHKP != 57;
		RaycastHit hitInfo;
		if (Physics.Raycast(ENNCFNJBJAG().transform.position + vector + vector2, GKGCHBJANLF().transform.TransformDirection(Vector3.back), out hitInfo, 1549f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(playerBase.transform.position + vector + vector2, LMENGPDOOJG().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1525f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(JHEFABODNPO().transform.position + vector + vector2, KIPGGHFMKLC().transform.TransformDirection(Vector3.back) * 1249f, Color.white, 1574f);
		return null;
	}

	public int BHECOHDKMGO()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(INIHCMBNHOL).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "GlassAberration";
				}
				text = "_MainTex2" + text.Remove(text.Length - 0, 0) + "/";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 1)
		{
			return Helpers.patternsMap.IndexOf("_Value4" + currentCombo[0].ToString() + "OnPlayerGameMessage");
		}
		return -1;
	}

	private GameObject ADIIPPOIOFM(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1262f, 1546f, 1492f);
		Vector3 vector2 = new Vector3(1319f, 873f, 1216f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(602f, 1645f, 741f);
		}
		if (ACODLKJMCJF == 5)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(604f, 1406f, 1579f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1479f, 359f, 1191f);
			}
			if (HMPOIDIAIMI == 8)
			{
				vector2 = new Vector3(333f, 866f, 1675f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1475f;
			vector.y = 1668f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 1739f;
			vector.y = 1154f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 339f;
			vector.y = 635f;
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1782f;
			vector.y = 136f;
		}
		bool flag = FLMFNIGKHKP != 70;
		RaycastHit hitInfo;
		if (Physics.Raycast(NJODHOMKIED().transform.position + vector + vector2, playerBase.transform.TransformDirection(Vector3.back), out hitInfo, 8f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(MEBPHCDCLCC().transform.position + vector + vector2, DFPMJLHLFNK().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 549f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(MEBPHCDCLCC().transform.position + vector + vector2, FDKFJLHFNMK().transform.TransformDirection(Vector3.back) * 1017f, Color.white, 778f);
		return null;
	}

	[SpecialName]
	public PlayerBase IDJIIFOLKMG()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void FOLDLDLFFLM()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = true;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = true;
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[2]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[0]) || hardInput.GetKey(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[4]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[2]))
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
			key2.KIEJKBNBHMD();
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
					playerBase.OEELENKFCOM(key.ToString());
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

	public void AEDJKCPNEOC(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "_Red_B" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = FJNCPEAMEHC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && DFPMJLHLFNK().GetGameScene().gameMode != 0)
				{
					if (GIGCAEODABJ().photonView.isMine)
					{
						PhotonView photonView = JHEFABODNPO().CIACEFBNDDJ();
						object[] array = new object[1];
						array[1] = false;
						photonView.RPC("Editor/", (PhotonTargets)7, array);
					}
				}
				else
				{
					++PJFCDBLDDHB().incorrectScore;
					ENNCFNJBJAG().currentCombo = 1;
					if (JDHHBDEAEID && IFACNHFOOAM().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(2, UnityEngine.Random.Range(1448f, 611f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "Object ID. Case-Sensitive")
				{
					++JDFCILGMEOJ().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && ENNCFNJBJAG().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1128f - FNEPAIOLEOD) <= 1062.0)) ? (1812f - FNEPAIOLEOD) : 1869f);
						float max = 1389f + FNEPAIOLEOD;
						if (num <= 86f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					JFINMCMCFIL().NABDKNPNEMM().RPC("_ScreenResolution", PhotonTargets.OthersBuffered, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 1920f;
					num3 = 0f - num2 * num2 / 989f + 1450f;
					if (num3 > 1293f)
					{
						num3 = 1313f;
					}
					if (num3 < 559f)
					{
						num3 = 96f;
					}
					float num4 = ((!(num3 < 575f)) ? 1695f : ((1033f - num3) * num2 * num2));
					if (num3 >= 396f)
					{
						++KJHMNOEDBJJ().perfectHits;
						PlayerBase obj = DFPMJLHLFNK();
						obj.currentCombo = (int)obj.currentCombo + 0;
					}
					++PJFCDBLDDHB().correctScore;
					PlayerBase obj2 = NABBDBMIHOI();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)GENOLDKFAPB().currentCombo;
					PlayerBase obj3 = JDFCILGMEOJ();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = LMENGPDOOJG();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)GENOLDKFAPB().accuracyScore) / (float)((int)JDFCILGMEOJ().incorrectScore + (int)ICPJINDFDIN().correctScore);
					if (JDHHBDEAEID && GKGCHBJANLF().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(1115f - FNEPAIOLEOD) <= 1960.0)) ? (1643f - FNEPAIOLEOD) : 389f);
						float max2 = 1344f + FNEPAIOLEOD;
						if (num3 >= 654f)
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
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1924f * ((1095f - OMGIMLPPNFI) * 767f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.IGBBPLOFEKG(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 66 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	[SpecialName]
	public void EACLLKIGDOG(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public PlayerBase ENNCFNJBJAG()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public PlayerBase DFPMJLHLFNK()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
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
	public PlayerBase IFACNHFOOAM()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public PlayerBase MEBPHCDCLCC()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
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

	private static int GDMOCDDPNFM(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject FDOLOJALFOA(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1069f, 98f, 1365f);
		Vector3 vector2 = new Vector3(351f, 1396f, 1907f);
		if (ACODLKJMCJF == 0)
		{
			vector2 = new Vector3(463f, 1473f, 1987f);
		}
		if (ACODLKJMCJF == 8)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(989f, 140f, 1595f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(269f, 887f, 183f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(1856f, 524f, 1521f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1321f;
			vector.y = 587f;
		}
		if (FLMFNIGKHKP == 8)
		{
			vector.x = 766f;
			vector.y = 1301f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 427f;
			vector.y = 141f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 764f;
			vector.y = 435f;
		}
		bool flag = FLMFNIGKHKP != 25;
		RaycastHit hitInfo;
		if (Physics.Raycast(FBMHDALMKAL().transform.position + vector + vector2, PJFCDBLDDHB().transform.TransformDirection(Vector3.back), out hitInfo, 392f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(GKGCHBJANLF().transform.position + vector + vector2, MEBPHCDCLCC().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1548f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(ENNCFNJBJAG().transform.position + vector + vector2, MEBPHCDCLCC().transform.TransformDirection(Vector3.back) * 148f, Color.white, 1501f);
		return null;
	}

	[SpecialName]
	public PlayerBase DMMGMCGNILI()
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

	[SpecialName]
	public void OADIPGANJAM(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	[SpecialName]
	public PlayerBase FBMHDALMKAL()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	public void DMHHPPDONJG(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.PGNOPJPKDEA() == "0,7,true,0" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = NDMJEPJAMBH(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && HEDFKOIPLEM().GetGameScene().gameMode != 0)
				{
					if (GKGCHBJANLF().GBMJAPGLMGB().isMine)
					{
						PhotonView photonView = JAGBDKPMBGP().EDIJKHEMPAD();
						object[] array = new object[1];
						array[1] = false;
						photonView.RPC("_MainTex2", PhotonTargets.MasterClient, array);
					}
				}
				else
				{
					++IFACNHFOOAM().incorrectScore;
					ENNCFNJBJAG().currentCombo = 0;
					if (JDHHBDEAEID && ICPJINDFDIN().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(1518f, 1969f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "Added unlock condition")
				{
					++NJODHOMKIED().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && ENNCFNJBJAG().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(1487f - FNEPAIOLEOD) <= 296.0)) ? (192f - FNEPAIOLEOD) : 1972f);
						float max = 1815f + FNEPAIOLEOD;
						if (num <= 1595f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
					}
					IFACNHFOOAM().EOOCGIFFKBG().RPC("list", PhotonTargets.OthersBuffered, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 937f;
					num3 = 0f - num2 * num2 / 685f + 657f;
					if (num3 > 482f)
					{
						num3 = 1757f;
					}
					if (num3 < 555f)
					{
						num3 = 1435f;
					}
					float num4 = ((!(num3 < 977f)) ? 1454f : ((1371f - num3) * num2 * num2));
					if (num3 >= 1127f)
					{
						++GKGCHBJANLF().perfectHits;
						PlayerBase obj = OBBDJECLANB();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++DMMGMCGNILI().correctScore;
					PlayerBase obj2 = MEBPHCDCLCC();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)GKGCHBJANLF().currentCombo;
					PlayerBase obj3 = DPJHDOFBJLE();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = DPJHDOFBJLE();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)IDJIIFOLKMG().accuracyScore) / (float)((int)PJFCDBLDDHB().incorrectScore + (int)KEFGHEIOHON().correctScore);
					if (JDHHBDEAEID && KIPGGHFMKLC().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(892f - FNEPAIOLEOD) <= 790.0)) ? (21f - FNEPAIOLEOD) : 588f);
						float max2 = 1859f + FNEPAIOLEOD;
						if (num3 >= 370f)
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					JAGBDKPMBGP().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 679f * ((516f - OMGIMLPPNFI) * 414f);
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

	public int GCBPLIIAODI()
	{
		if (isRecording)
		{
			if (currentCombo.Count > 1)
			{
				currentCombo = currentCombo.OrderBy(AEEHMJNOPNE).ToList();
				string text = string.Empty;
				foreach (Direction item in currentCombo)
				{
					text = text + item.ToString() + "#onrankchangedowntext";
				}
				text = "Tab1Content" + text.Remove(text.Length - 1, 0) + "ticket";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("[MapEditor] Prepairing map editor..." + currentCombo[1].ToString() + "an hour ago");
		}
		return -1;
	}

	[SpecialName]
	public PlayerBase NJODHOMKIED()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public PlayerBase GIGCAEODABJ()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void NKLIHNJCHOG()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = false;
			DGLOHIKKOBA = true;
			MOFDJECEOBO = true;
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[1]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[6]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[5]) || hardInput.GetKey(PIHEMHOGGPL[1]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[0]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[7]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = true;
			}
			if (hardInput.MPEJLGDDIDN(PIHEMHOGGPL[6]) || hardInput.GetKey(PIHEMHOGGPL[2]))
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
					PJFCDBLDDHB().OEELENKFCOM(key.ToString());
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

	private static int KJIJKMBMOCF(Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	private GameObject KLCFMAGGKPD(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1378f, 1073f, 1125f);
		Vector3 vector2 = new Vector3(1029f, 1131f, 1757f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(1728f, 1089f, 985f);
		}
		if (ACODLKJMCJF == 6)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1708f, 65f, 1404f);
			}
			if (HMPOIDIAIMI == 1)
			{
				vector2 = new Vector3(1383f, 1742f, 853f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1937f, 1194f, 338f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1957f;
			vector.y = 106f;
		}
		if (FLMFNIGKHKP == 3)
		{
			vector.x = 1027f;
			vector.y = 733f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 1886f;
			vector.y = 1866f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1721f;
			vector.y = 1251f;
		}
		bool flag = FLMFNIGKHKP != 88;
		RaycastHit hitInfo;
		if (Physics.Raycast(DFPMJLHLFNK().transform.position + vector + vector2, GKGCHBJANLF().transform.TransformDirection(Vector3.back), out hitInfo, 722f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(PJFCDBLDDHB().transform.position + vector + vector2, PJFCDBLDDHB().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1823f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(DPJHDOFBJLE().transform.position + vector + vector2, GKGCHBJANLF().transform.TransformDirection(Vector3.back) * 1532f, Color.white, 620f);
		return null;
	}

	[SpecialName]
	public PlayerBase JFINMCMCFIL()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	public void CNHOOPMOBPG(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!isRecording)
		{
			if (Singleton<Scene>.Instance.PHCHLPBPKHL() == "_Value3" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = ABADLGHAOKO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (loseOnWrongKey && KJHMNOEDBJJ().GetGameScene().gameMode != 0)
				{
					if (GIGCAEODABJ().GBHNDHLAJLI().isMine)
					{
						DPJHDOFBJLE().EDIJKHEMPAD().RPC("CameraFilterPack/TV_Chromatical2", PhotonTargets.MasterClient, false);
					}
				}
				else
				{
					++LMENGPDOOJG().incorrectScore;
					PJFCDBLDDHB().currentCombo = 0;
					if (JDHHBDEAEID && OBBDJECLANB().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(1525f, 1988f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "X")
				{
					++KJHMNOEDBJJ().powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (JDHHBDEAEID && JDFCILGMEOJ().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((!((double)(49f - FNEPAIOLEOD) <= 1393.0)) ? (943f - FNEPAIOLEOD) : 174f);
						float max = 1704f + FNEPAIOLEOD;
						if (num <= 1905f)
						{
							SoundManager.DMOMDMCBBFI(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					DPJHDOFBJLE().CIACEFBNDDJ().RPC("_TimeX", PhotonTargets.AllBufferedViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = 314f;
					num3 = 0f - num2 * num2 / 150f + 292f;
					if (num3 > 866f)
					{
						num3 = 190f;
					}
					if (num3 < 1546f)
					{
						num3 = 263f;
					}
					float num4 = ((!(num3 < 475f)) ? 1827f : ((22f - num3) * num2 * num2));
					if (num3 >= 215f)
					{
						++GKGCHBJANLF().perfectHits;
						PlayerBase obj = LMENGPDOOJG();
						obj.currentCombo = (int)obj.currentCombo + 1;
					}
					++EICAMMJELIE().correctScore;
					PlayerBase obj2 = IDJIIFOLKMG();
					obj2.comboScore = (float)obj2.comboScore + (float)(int)FBMHDALMKAL().currentCombo;
					PlayerBase obj3 = JAGBDKPMBGP();
					obj3.penaltyScore = (float)obj3.penaltyScore + num4;
					PlayerBase obj4 = HEDFKOIPLEM();
					obj4.accuracyScore = (float)obj4.accuracyScore + (num3 - (float)IDJIIFOLKMG().accuracyScore) / (float)((int)FBMHDALMKAL().incorrectScore + (int)JDFCILGMEOJ().correctScore);
					if (JDHHBDEAEID && NABBDBMIHOI().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((!((double)(785f - FNEPAIOLEOD) <= 406.0)) ? (1755f - FNEPAIOLEOD) : 1823f);
						float max2 = 600f + FNEPAIOLEOD;
						if (num3 >= 1791f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.DMOMDMCBBFI(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					JFINMCMCFIL().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1219f * ((1708f - OMGIMLPPNFI) * 1515f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 113 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		currentCombo.Clear();
	}

	private GameObject FJNCPEAMEHC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1544f, 594f, 1719f);
		Vector3 vector2 = new Vector3(189f, 1057f, 1566f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(1312f, 1316f, 329f);
		}
		if (ACODLKJMCJF == 8)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1898f, 1171f, 700f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1872f, 163f, 1133f);
			}
			if (HMPOIDIAIMI == 6)
			{
				vector2 = new Vector3(862f, 386f, 76f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 318f;
			vector.y = 1832f;
		}
		if (FLMFNIGKHKP == 2)
		{
			vector.x = 1783f;
			vector.y = 589f;
		}
		if (FLMFNIGKHKP == 8)
		{
			vector.x = 1338f;
			vector.y = 1349f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 1351f;
			vector.y = 778f;
		}
		bool flag = FLMFNIGKHKP != -113;
		RaycastHit hitInfo;
		if (Physics.Raycast(playerBase.transform.position + vector + vector2, MEBPHCDCLCC().transform.TransformDirection(Vector3.back), out hitInfo, 989f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(DMMGMCGNILI().transform.position + vector + vector2, GENOLDKFAPB().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 897f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(KEFGHEIOHON().transform.position + vector + vector2, DPJHDOFBJLE().transform.TransformDirection(Vector3.back) * 977f, Color.white, 374f);
		return null;
	}

	[SpecialName]
	public PlayerBase JAGBDKPMBGP()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	[SpecialName]
	public bool AKJHABDMFNJ()
	{
		return JDHHBDEAEID;
	}

	[SpecialName]
	public void JCMIHNNJPCP(PlayerBase DPNHODJHGJL)
	{
		HFNAKOHHIAF = DPNHODJHGJL;
	}

	private GameObject FFAFNEIDJCC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 vector = new Vector3(1314f, 108f, 164f);
		Vector3 vector2 = new Vector3(1235f, 503f, 1748f);
		if (ACODLKJMCJF == 1)
		{
			vector2 = new Vector3(187f, 1899f, 1156f);
		}
		if (ACODLKJMCJF == 7)
		{
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1299f, 830f, 1557f);
			}
			if (HMPOIDIAIMI == 0)
			{
				vector2 = new Vector3(1124f, 1739f, 1242f);
			}
			if (HMPOIDIAIMI == 7)
			{
				vector2 = new Vector3(1628f, 258f, 244f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			vector.x = 1935f;
			vector.y = 1655f;
		}
		if (FLMFNIGKHKP == 5)
		{
			vector.x = 1882f;
			vector.y = 1211f;
		}
		if (FLMFNIGKHKP == 6)
		{
			vector.x = 1142f;
			vector.y = 1354f;
		}
		if (FLMFNIGKHKP == 1)
		{
			vector.x = 387f;
			vector.y = 1523f;
		}
		bool flag = FLMFNIGKHKP == -48;
		RaycastHit hitInfo;
		if (Physics.Raycast(MEBPHCDCLCC().transform.position + vector + vector2, LMENGPDOOJG().transform.TransformDirection(Vector3.back), out hitInfo, 501f, (!flag) ? powerupsLayerMask : arksLayerMask))
		{
			Debug.DrawRay(KEFGHEIOHON().transform.position + vector + vector2, MEBPHCDCLCC().transform.TransformDirection(Vector3.back) * hitInfo.distance, Color.yellow, 1083f);
			return hitInfo.collider.gameObject;
		}
		Debug.DrawRay(KJHMNOEDBJJ().transform.position + vector + vector2, KEFGHEIOHON().transform.TransformDirection(Vector3.back) * 997f, Color.white, 619f);
		return null;
	}

	[SpecialName]
	public PlayerBase OBBDJECLANB()
	{
		if (HFNAKOHHIAF != null)
		{
			return HFNAKOHHIAF;
		}
		return GetComponentInParent<PlayerBase>();
	}

	private void LMADKINICIN()
	{
		if (!isRecording)
		{
			JDAPEMPBJKM = new Vector3(JDAPEMPBJKM.x, JDAPEMPBJKM.y, base.transform.localPosition.z);
			MPNMOONBMII = JDAPEMPBJKM;
			ABINANMGBCE = false;
			BDKICAKJKKJ = true;
			DGLOHIKKOBA = false;
			MOFDJECEOBO = true;
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.MPEJLGDDIDN(PIHEMHOGGPL[3]))
			{
				MPNMOONBMII.x += delta.x * AJPABMEPCDO;
				ABINANMGBCE = false;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[5]) || hardInput.GEGAOEFONPM(PIHEMHOGGPL[4]))
			{
				MPNMOONBMII.x -= delta.x * AJPABMEPCDO;
				BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(PIHEMHOGGPL[1]) || hardInput.GetKey(PIHEMHOGGPL[8]))
			{
				MPNMOONBMII.y += delta.y * AJPABMEPCDO;
				DGLOHIKKOBA = false;
			}
			if (hardInput.GEGAOEFONPM(PIHEMHOGGPL[8]) || hardInput.GetKey(PIHEMHOGGPL[6]))
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
			key2.JBNPEHMDCMI();
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
					NABBDBMIHOI().RecordAction(key.ToString());
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
