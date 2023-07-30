// from dnspy (right click -> edit class)
// can't recompile in dnspy/ilspy

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Token: 0x0200048F RID: 1167
public class MapEditor : Singleton<MapEditor>
{
	// Token: 0x06010A6D RID: 68205 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void SetBPMText(string DPNHODJHGJL)
	{
		this.SetBPM(float.Parse(DPNHODJHGJL));
	}

	// Token: 0x06010A6E RID: 68206 RVA: 0x000A5F74 File Offset: 0x000A4174
	public void GKGGAIFBLNN()
	{
		Singleton<UI>.Instance.MPAOPOODNAK();
		this.isRecording = !this.isRecording;
		this.UpdateBottomBar();
	}

	// Token: 0x06010A6F RID: 68207 RVA: 0x000A5F95 File Offset: 0x000A4195
	public bool IsMapLoaded()
	{
		return this.currentState == MapEditor.EditorState.MapLoaded && !string.IsNullOrEmpty(this.CAFHKDIIDEE);
	}

	// Token: 0x06010A70 RID: 68208 RVA: 0x000A5FB4 File Offset: 0x000A41B4
	public void OnAboutButton()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("MapEditor v." + Helpers.GetGameVersion() + "\nCreated by Oxy949", "#ok", null, true, false, 0f);
	}

	// Token: 0x06010A71 RID: 68209 RVA: 0x000A5FE1 File Offset: 0x000A41E1
	public void SetZoom(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		Singleton<UI>.Instance.ClearSelection();
		this.zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	// Token: 0x06010A72 RID: 68210 RVA: 0x000A6009 File Offset: 0x000A4209
	public void OnCreateNewMapButton()
	{
		base.StartCoroutine(this.OECGEKPJPCB());
	}

	// Token: 0x06010A73 RID: 68211 RVA: 0x0057246C File Offset: 0x0057066C
	public void HNEJDFKAFAE()
	{
		string nbebmkfpbep = "_Value";
		Singleton<GameManager>.Instance.CKMMHJLDADB(nbebmkfpbep, false);
	}

	// Token: 0x06010A74 RID: 68212 RVA: 0x0057248C File Offset: 0x0057068C
	private IEnumerator GOGFAHNINFB()
	{
		Singleton<UI>.Instance.SwitchView("Loading", 0.2f);
		yield return new WaitForSeconds(0.2f);
		Debug.Log("[MapEditor] Openning " + this.CAFHKDIIDEE);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE);
		Debug.Log("[MapEditor] Loading music...");
		string fullName = new FileInfo(mapData.fullLevelPath + "/" + mapData.mapData.musicFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, true, false));
		AudioClip audioClip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		this.audioSampler.Init(audioClip, 0f, false);
		Debug.Log("[MapEditor] Prepairing map editor...");
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
		this.SetEditedData(mapData.mapData);
		this.BPOJHBIEMOJ();
		base.StopCoroutine(this.NLIGGKFCFNM());
		base.StartCoroutine(this.NLIGGKFCFNM());
		Debug.Log("[MapEditor] Loading events...");
		this.currentTimeSlider.minValue = 0f;
		this.currentTimeSlider.maxValue = audioClip.length;
		this.currentTimeSlider.value = 0f;
		this.currentState = MapEditor.EditorState.MapLoaded;
		this.UpdateTopMenu();
		this.UpdateBottomBar();
		this.FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init", true);
		yield return new WaitForSeconds(0.5f);
		Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (this.editedMapData.configVersion < MapData.GetLastConfigVersion() && !Singleton<SaveSystem>.Instance.HasKey("maps." + this.CAFHKDIIDEE + ".sawoutdatedmessage", null))
		{
			base.StartCoroutine(this.ShowOutdatedMapWarning());
		}
		yield break;
	}

	// Token: 0x06010A75 RID: 68213 RVA: 0x000A6018 File Offset: 0x000A4218
	private static float MOEJMFOFKKH(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010A76 RID: 68214 RVA: 0x005724A8 File Offset: 0x005706A8
	public void Slowmo()
	{
		this.audioSampler.audioSources[1].pitch -= 0.25f;
		if (this.audioSampler.audioSources[1].pitch < 0.25f)
		{
			this.audioSampler.audioSources[1].pitch = 0.25f;
		}
	}

	// Token: 0x06010A77 RID: 68215 RVA: 0x000A6020 File Offset: 0x000A4220
	public void OALNCNLIOGD()
	{
		this.editedMapData.unlockConditions.Add(string.Empty);
		this.MMGJGLLFKML();
		Singleton<EditorHistoryHandler>.Instance.KMIIHCELMAG("_Value4", true);
	}

	// Token: 0x06010A78 RID: 68216 RVA: 0x00572514 File Offset: 0x00570714
	private void DCPNKANPBHB()
	{
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (!this.GPNKNBLBFOD.isEditing && this.currentState == MapEditor.EditorState.MapLoaded)
		{
			if (Input.mouseScrollDelta.y != 944f)
			{
				if (Input.GetKey((KeyCode)68) || Input.GetKey((KeyCode)(-20)))
				{
					this.zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 1744f;
				}
				else
				{
					this.CLFPFIMABIH(-Input.mouseScrollDelta.y * Camera.main.orthographicSize * 311f, false);
				}
			}
			if (!Input.GetKey(KeyCode.Pipe) && !Input.GetKey((KeyCode)(-197)) && !flag)
			{
				if (Input.GetKeyDown((KeyCode)(-76)))
				{
					this.TogglePlay();
				}
				if (Input.GetKeyDown(KeyCode.Pipe))
				{
					this.GKGGAIFBLNN();
				}
				if (Input.GetKeyDown(KeyCode.I))
				{
					this.OnDeleteButton();
				}
				if (Input.GetKeyDown((KeyCode)(-121)))
				{
					this.CJFGHCLBEAO();
				}
				if (Input.GetKeyDown((KeyCode)(-117)))
				{
					this.IMMHGJFBGAJ(this.useBPMSnap);
					this.useBpmToggle.isOn = this.useBPMSnap;
				}
				if (Input.GetKeyDown((KeyCode)86))
				{
					this.FGHJLGCPPFL();
				}
				if (Input.GetKeyDown((KeyCode)(-23)))
				{
					this.SwichCanvas();
				}
			}
		}
		if (Input.GetKey((KeyCode)(-183)) || Input.GetKey((KeyCode)183))
		{
			if (Input.GetKeyDown(KeyCode.Ampersand))
			{
				Singleton<EditorHistoryHandler>.Instance.ONGIEKJOKFN();
			}
			if (Input.GetKeyDown(KeyCode.I))
			{
				Singleton<EditorHistoryHandler>.Instance.PJNLCGALEND();
			}
			if (this.currentState == MapEditor.EditorState.MapLoaded && !flag)
			{
				if (Input.GetKeyDown((KeyCode)(-99)))
				{
					Singleton<EditorArcsSelector>.Instance.GLHMOLAINMH();
				}
				if (Input.GetKeyDown((KeyCode)(-73)))
				{
					Singleton<EditorArcsSelector>.Instance.BOAHKMGFJNG();
				}
				if (Input.GetKeyDown((KeyCode)(-93)))
				{
					Singleton<EditorArcsSelector>.Instance.HIMNBHFIJKH(this.currentTime);
				}
				if (Input.GetMouseButtonDown(4))
				{
					this.SetZoom(1416f);
				}
				if (Input.GetKeyDown((KeyCode)(-27)))
				{
					this.ALMCMPBFBHN();
				}
			}
		}
		if (!this.isRecording && !this.GPNKNBLBFOD.isEditing && !flag)
		{
			if (!Input.GetKey(KeyCode.DoubleQuote) && !Input.GetKey((KeyCode)138))
			{
				if (Input.GetKeyDown((KeyCode)(-19)))
				{
					this.OnAddButton(0);
				}
				if (Input.GetKeyDown(KeyCode.Clear))
				{
					this.OnAddButton(0);
				}
			}
			if (Input.GetKey((KeyCode)133))
			{
				this.NLJJIAIEIDH(377f * Camera.main.orthographicSize, true);
			}
			if (Input.GetKey(KeyCode.M))
			{
				this.CLFPFIMABIH(384f * Camera.main.orthographicSize, true);
			}
			if (Input.GetKeyDown((KeyCode)182) && this.currentEventsCanvasId < this.eventsCanvases.Count - 1)
			{
				this.currentEventsCanvasId++;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(true);
				}
			}
			if (Input.GetKeyDown(KeyCode.Pause) && this.currentEventsCanvasId > 1)
			{
				this.currentEventsCanvasId--;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(true);
				}
			}
		}
	}

	// Token: 0x06010A79 RID: 68217 RVA: 0x00572898 File Offset: 0x00570A98
	public void SpeedUp()
	{
		this.audioSampler.audioSources[1].pitch += 0.25f;
		if (this.audioSampler.audioSources[1].pitch > 1f)
		{
			this.audioSampler.audioSources[1].pitch = 1f;
		}
	}

	// Token: 0x06010A7A RID: 68218 RVA: 0x00572904 File Offset: 0x00570B04
	public IEnumerator PCHCMGCHMIG()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#updateoutdatedmap", "#yes", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().value = (float)MapData.GetLastConfigVersion();
			yield return base.StartCoroutine(this.Save(true, true));
			this.IIIGPJIJHKD(this.CAFHKDIIDEE);
		}
		Singleton<SaveSystem>.Instance.SetBool("maps." + this.CAFHKDIIDEE + ".sawoutdatedmessage", true, null);
		yield break;
	}

	// Token: 0x06010A7B RID: 68219 RVA: 0x000A604D File Offset: 0x000A424D
	public void ECBKKGFOJEJ()
	{
		this.BLLONNLMMNA();
	}

	// Token: 0x06010A7C RID: 68220 RVA: 0x00572920 File Offset: 0x00570B20
	public void OnPublichButton()
	{
		if (Singleton<GameManager>.Instance.GetCurrentBanLevel() <= 1)
		{
			base.StartCoroutine(this.ONJIIJDEFOM());
		}
		else
		{
			RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
			Singleton<MessageBoxPanel>.Instance.DisplayMessage(string.Concat(new string[]
			{
				"<b>#",
				actveBan.bantype.ToString().ToLower(),
				"received</b>\n#reason: ",
				actveBan.reason,
				"\n\n#",
				actveBan.bantype.ToString().ToLower(),
				"restrictions\n\n#until: ",
				(!(actveBan.until == "-1")) ? actveBan.until : "#forever"
			}), "#ok", null, true, false, 0f);
		}
	}

	// Token: 0x06010A7D RID: 68221 RVA: 0x00572A00 File Offset: 0x00570C00
	public GameObject CJMPAEHGCBK(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null, bool KFDLOHFINOD = true)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "_TimeX";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().CMNPEMEIJEJ();
		if (KFDLOHFINOD)
		{
			Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("settings.showHP", false);
			this.UpdateBottomBar();
			this.FindNearestEvent(false);
		}
		return gameObject;
	}

	// Token: 0x06010A7E RID: 68222 RVA: 0x00572A94 File Offset: 0x00570C94
	private void DPGILDLHMLM()
	{
		this.currentBPMText.text = LocalizationService.Instance.GetLocalizatedText("#currentbpm: ");
		this.currentBpmOffsetInputField.text = string.Empty + this.BPMOffset;
		this.currentBpmInputField.text = string.Empty + this.BPM;
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvas.bpmGrid.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					Transform transform = (Transform)obj;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator2 as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		if (this.useBPMSnap)
		{
			int num = 0;
			while ((float)num <= (float)Mathf.CeilToInt(this.editedMapData.musicTime) * (this.BPM * (float)this.BPMSplit / 60f))
			{
				foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.bpmGridGameObject);
					gameObject.transform.SetParent(eventsCanvas2.bpmGrid);
					gameObject.transform.localPosition = new Vector3(this.BPMOffset + (float)num * (60f / (this.BPM * (float)this.BPMSplit)), 0f, 0f);
					gameObject.name = "bpmgrid";
				}
				num++;
			}
		}
	}

	// Token: 0x06010A7F RID: 68223 RVA: 0x000A6055 File Offset: 0x000A4255
	public MapEditor()
	{
	}

	// Token: 0x06010A80 RID: 68224 RVA: 0x00572C90 File Offset: 0x00570E90
	public float JCNHFKOAHHH(float GEMDHBEGEFH)
	{
		if (this.useBPMSnap)
		{
			bool flag = false;
			float result = 1047f;
			float num = 998f;
			int num2 = 1;
			while ((float)num2 <= (float)Mathf.CeilToInt(this.editedMapData.musicTime) * (this.BPM * (float)this.BPMSplit / 1022f))
			{
				float num3 = this.BPMOffset + (float)num2 * (1460f / (this.BPM * (float)this.BPMSplit));
				if (flag)
				{
					result = num3;
					num = Mathf.Abs(GEMDHBEGEFH - num3);
					flag = true;
				}
				if (Mathf.Abs(GEMDHBEGEFH - num3) < num)
				{
					result = num3;
					num = Mathf.Abs(GEMDHBEGEFH - num3);
				}
				num2++;
			}
			return result;
		}
		return GEMDHBEGEFH;
	}

	// Token: 0x06010A81 RID: 68225 RVA: 0x00572D44 File Offset: 0x00570F44
	public IEnumerator UpdateMapAssets(string BNJFKKGOACF, string EAGJAOLHFGB, string FLMDNANCAAC, string CAFHKDIIDEE, bool MEPPNHMBCFL = false, int ACODLKJMCJF = 1)
	{
		Debug.Log("[MapEditor] Updating map assets");
		string text = BNJFKKGOACF + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(text, true));
		Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
		if (!string.IsNullOrEmpty(EAGJAOLHFGB) && File.Exists(EAGJAOLHFGB))
		{
			FileInfo fileInfo = new FileInfo(EAGJAOLHFGB);
			File.Delete(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.iconFile);
			File.Copy(EAGJAOLHFGB, BNJFKKGOACF + "/icon" + fileInfo.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.iconFile = "icon" + fileInfo.Extension;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(BNJFKKGOACF + "/icon" + fileInfo.Extension, BNJFKKGOACF + "/icon" + fileInfo.Extension, true, false));
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).icon = (Sprite)ResourcesManager.GetLoadedResource(BNJFKKGOACF + "/icon" + fileInfo.Extension);
		}
		if (!string.IsNullOrEmpty(FLMDNANCAAC) && File.Exists(FLMDNANCAAC))
		{
			FileInfo fileInfo2 = new FileInfo(FLMDNANCAAC);
			File.Delete(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile);
			File.Copy(FLMDNANCAAC, BNJFKKGOACF + "/music" + fileInfo2.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile = "music" + fileInfo2.Extension;
			float musicTime = 0f;
			string fullName = new FileInfo(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile).FullName;
			yield return base.StartCoroutine(Helpers.GetAudioLength(fullName, true));
			musicTime = Helpers.resultAudioLength;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicTime = musicTime;
		}
		if (!string.IsNullOrEmpty(CAFHKDIIDEE) && MEPPNHMBCFL)
		{
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.name = CAFHKDIIDEE;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.configVersion = MapData.GetLastConfigVersion();
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapperSteamID = SteamUser.GetSteamID().m_SteamID;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.handCount = ACODLKJMCJF;
		}
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		Helpers.CheckDirectory(BNJFKKGOACF);
		yield return base.StartCoroutine(Helpers.SaveFile(BNJFKKGOACF + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		yield break;
	}

	// Token: 0x06010A82 RID: 68226 RVA: 0x00572D8C File Offset: 0x00570F8C
	public IEnumerator AddNewLevelResoure(string JFEBNHAPGBG, string MOMKGLKFJED)
	{
		if (!string.IsNullOrEmpty(MOMKGLKFJED) && File.Exists(MOMKGLKFJED))
		{
			FileInfo fileInfo = new FileInfo(MOMKGLKFJED);
			string text = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath + "/" + fileInfo.Name;
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(MOMKGLKFJED, text);
			yield return null;
			MapResource item = new MapResource(JFEBNHAPGBG, "Sprite", fileInfo.Name);
			this.editedMapData.levelResources.Add(item);
			yield return base.StartCoroutine(this.Save(false, true));
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
			this.ReloadResList();
		}
		yield break;
	}

	// Token: 0x06010A83 RID: 68227 RVA: 0x00572DB8 File Offset: 0x00570FB8
	public void LJDIIDDCFIC()
	{
		MapData editedData = this.GetEditedData(false);
		int mapMaxScore = Helpers.GetMapMaxScore(editedData);
		float mapDifficulty = Helpers.GetMapDifficulty(editedData);
		if (editedData.configVersion >= 0 && !string.IsNullOrEmpty(editedData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(editedData.e, Singleton<SaveSystem>.Instance.folder));
				editedData.events.AddRange(editedData.events);
			}
			catch (Exception)
			{
			}
		}
		float num = editedData.speed;
		float num2 = editedData.speed;
		IEnumerable<MapEvent> events = editedData.events;
		if (MapEditor.LNIJKGECNME == null)
		{
			MapEditor.LNIJKGECNME = new Func<MapEvent, bool>(MapEditor.IFMCPCOBNNH);
		}
		List<MapEvent> list = events.Where(MapEditor.LNIJKGECNME).ToList<MapEvent>();
		if (list.Count > 1)
		{
			foreach (MapEvent mapEvent in list)
			{
				float num3 = float.Parse(mapEvent.data[0], CultureInfo.InvariantCulture);
				if (num > num3)
				{
					num = num3;
				}
				if (num2 < num3)
				{
					num2 = num3;
				}
			}
		}
		string format = "_Fade";
		string text = "_TimeX" + Environment.NewLine;
		text = text + "Set Satellite Emission" + Environment.NewLine;
		text = text + string.Format(format, "_Angle", mapDifficulty.ToString("Year_")) + Environment.NewLine;
		text = text + "ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: " + Environment.NewLine;
		text = text + string.Format(format, "action", mapMaxScore) + Environment.NewLine;
		text = text + string.Format(format, "_TimeX", editedData.musicTime.ToString("UseScanLine")) + Environment.NewLine;
		text = text + string.Format(format, "_MainTex2", editedData.lives + "_NeighbourMaxTex" + editedData.maxLives) + Environment.NewLine;
		text = text + string.Format(format, "inventory.selected.", num.ToString("#news") + "_Value4" + num2.ToString("SetParticlesColor")) + Environment.NewLine;
		text = text + ". Check if the server is available." + Environment.NewLine;
		Singleton<MessageBoxPanel>.Instance.DEAKLIGJIFG(text, "CameraFilterPack/Blur_Regular", null, true, true, 1030f);
	}

	// Token: 0x06010A84 RID: 68228 RVA: 0x000A6081 File Offset: 0x000A4281
	public void JFDOLNEKPJH()
	{
		this.BPMOffset = this.currentTime;
		this.KPGJNNBMPOH();
	}

	// Token: 0x06010A85 RID: 68229 RVA: 0x000A6081 File Offset: 0x000A4281
	public void DCDJMECHANG()
	{
		this.BPMOffset = this.currentTime;
		this.KPGJNNBMPOH();
	}

	// Token: 0x06010A86 RID: 68230 RVA: 0x000A6095 File Offset: 0x000A4295
	public void ToggleRecord()
	{
		Singleton<UI>.Instance.ClearSelection();
		this.isRecording = !this.isRecording;
		this.UpdateBottomBar();
	}

	// Token: 0x06010A87 RID: 68231 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void NKFBLFLABFM(string DPNHODJHGJL)
	{
		this.SetBPM(float.Parse(DPNHODJHGJL));
	}

	// Token: 0x06010A88 RID: 68232 RVA: 0x000A60B6 File Offset: 0x000A42B6
	public void SetBPMOffset(float DPNHODJHGJL)
	{
		this.BPMOffset = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010A89 RID: 68233 RVA: 0x000A60C5 File Offset: 0x000A42C5
	public bool MAONHJDBGAH()
	{
		return this.currentState != MapEditor.EditorState.MapLoaded || string.IsNullOrEmpty(this.CAFHKDIIDEE);
	}

	// Token: 0x06010A8A RID: 68234 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void GPFIJCDGDBB(string DPNHODJHGJL)
	{
		this.SetBPM(float.Parse(DPNHODJHGJL));
	}

	// Token: 0x06010A8B RID: 68235 RVA: 0x000A604D File Offset: 0x000A424D
	public void OnLicenceButton()
	{
		this.BLLONNLMMNA();
	}

	// Token: 0x06010A8C RID: 68236 RVA: 0x00573050 File Offset: 0x00571250
	public void OnFastVideoButton()
	{
		string nbebmkfpbep = "https://www.youtube.com/watch?v=cDVXukrKo74";
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, true);
	}

	// Token: 0x06010A8D RID: 68237 RVA: 0x00573070 File Offset: 0x00571270
	public void SetCustomBPM(string DPNHODJHGJL)
	{
		try
		{
			float bpm = float.Parse(DPNHODJHGJL, NumberStyles.Float);
			this.SetBPM(bpm);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06010A8E RID: 68238 RVA: 0x005730AC File Offset: 0x005712AC
	private void AKHCHINFBMJ()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 1;
		using (List<string>.Enumerator enumerator = this.editedMapData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				MapEditor.CFBBHNAOKPA cfbbhnaokpa = new MapEditor.CFBBHNAOKPA();
				cfbbhnaokpa.IEOKJCPAOHL = enumerator.Current;
				cfbbhnaokpa.ADPIKBBAKHP = this;
				MapEditor.NDFEKONPOMG ndfekonpomg = new MapEditor.NDFEKONPOMG();
				ndfekonpomg.KHCIOAJAKOO = cfbbhnaokpa;
				ndfekonpomg.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				ndfekonpomg.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				ndfekonpomg.OBFJPHLBFOL.transform.localScale = new Vector3(1535f, 690f, 1451f);
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = cfbbhnaokpa.IEOKJCPAOHL;
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(ndfekonpomg.FJDBPPKABJE));
				num += 0;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(659f, 1165f, 73f);
	}

	// Token: 0x06010A8F RID: 68239 RVA: 0x00573278 File Offset: 0x00571478
	private IEnumerator GKGAABCOKHJ(int HMGBJCGOLMI)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		if (HMGBJCGOLMI == 0)
		{
			string result = GameObject.Find("NewIconFileSelector").GetComponent<FileSelector>().result;
			Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
			yield return new WaitForSeconds(0.2f);
			FileInfo fileInfo = new FileInfo(result);
			File.Delete(fullLevelPath + "/" + this.editedMapData.iconFile);
			File.Copy(result, fullLevelPath + "/icon" + fileInfo.Extension);
			this.editedMapData.iconFile = "icon" + fileInfo.Extension;
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData.iconFile = this.editedMapData.iconFile;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullLevelPath + "/icon" + fileInfo.Extension, fullLevelPath + "/icon" + fileInfo.Extension, true, false));
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).icon = (Sprite)ResourcesManager.GetLoadedResource(fullLevelPath + "/icon" + fileInfo.Extension);
			yield return base.StartCoroutine(this.Save(false, true));
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			this.currentState = MapEditor.EditorState.MapLoaded;
		}
		if (HMGBJCGOLMI == 1)
		{
			string result2 = GameObject.Find("NewMusicFileSelector").GetComponent<FileSelector>().result;
			Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
			yield return new WaitForSeconds(0.2f);
			FileInfo fileInfo2 = new FileInfo(result2);
			File.Delete(fullLevelPath + "/" + this.editedMapData.musicFile);
			File.Copy(result2, fullLevelPath + "/music" + fileInfo2.Extension);
			this.editedMapData.musicFile = "music" + fileInfo2.Extension;
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData.musicFile = this.editedMapData.musicFile;
			float musicTime = 0f;
			string fullName = new FileInfo(fullLevelPath + "/" + this.editedMapData.musicFile).FullName;
			yield return base.StartCoroutine(Helpers.GetAudioLength(fullName, true));
			musicTime = Helpers.resultAudioLength;
			this.editedMapData.musicTime = musicTime;
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData.musicTime = this.editedMapData.musicTime;
			this.currentState = MapEditor.EditorState.MapLoaded;
			yield return base.StartCoroutine(this.Save(false, false));
			this.currentState = MapEditor.EditorState.MapLoaded;
			this.IIIGPJIJHKD(this.CAFHKDIIDEE);
		}
		yield break;
	}

	// Token: 0x06010A90 RID: 68240 RVA: 0x000A60E4 File Offset: 0x000A42E4
	public void IMMHGJFBGAJ(bool DPNHODJHGJL)
	{
		this.useBPMSnap = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010A91 RID: 68241 RVA: 0x000A5F66 File Offset: 0x000A4166
	public void JLHNACDFEFO(string DPNHODJHGJL)
	{
		this.SetBPM(float.Parse(DPNHODJHGJL));
	}

	// Token: 0x06010A92 RID: 68242 RVA: 0x0057329C File Offset: 0x0057149C
	public void AddRecordedEventGO(string NOJGGCLPPAM, int PGJECADBIOI, float NPAFFMIFMCD = -1f)
	{
		if (this.editedMapData.handCount < 2)
		{
			string item = NOJGGCLPPAM;
			if (NOJGGCLPPAM == "[Up]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData();
			}
			this.AddNewEvent((NPAFFMIFMCD >= 0f) ? NPAFFMIFMCD : this.currentTime, new List<string>
			{
				"SpawnObj",
				item
			}, true);
		}
		else
		{
			string arg = NOJGGCLPPAM;
			if (NOJGGCLPPAM == "[Up]")
			{
				arg = Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				arg = Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				arg = Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				arg = Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData();
			}
			this.AddNewEvent((NPAFFMIFMCD >= 0f) ? NPAFFMIFMCD : this.currentTime, new List<string>
			{
				"SpawnObj",
				arg + "," + PGJECADBIOI
			}, true);
		}
	}

	// Token: 0x06010A93 RID: 68243 RVA: 0x000A6018 File Offset: 0x000A4218
	private static float IGOPJHNGIGI(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010A94 RID: 68244 RVA: 0x000A60F3 File Offset: 0x000A42F3
	public void OnMapConfigButton()
	{
		this.currentState = MapEditor.EditorState.Busy;
		Singleton<UI>.Instance.SwitchView("MapConfig", 0.2f);
	}

	// Token: 0x06010A95 RID: 68245 RVA: 0x000A6110 File Offset: 0x000A4310
	[CompilerGenerated]
	private static bool IFMCPCOBNNH(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "SetSpeed";
	}

	// Token: 0x06010A96 RID: 68246 RVA: 0x000A6128 File Offset: 0x000A4328
	public void GGCIIPANENF()
	{
		Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
		Singleton<EditorArcsSelector>.Instance.CAOFJNHDGJC(this.currentTime);
		Singleton<EditorHistoryHandler>.Instance.EPMOMGMDLMN("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", true);
	}

	// Token: 0x06010A97 RID: 68247 RVA: 0x000A6159 File Offset: 0x000A4359
	public void BCJACEDONEF()
	{
		base.StartCoroutine(this.MECBCHDHOHE(false, true));
	}

	// Token: 0x06010A98 RID: 68248 RVA: 0x000A616A File Offset: 0x000A436A
	public void JNHJHOKCIBE()
	{
		this.LCJDCFFEMLP();
	}

	// Token: 0x06010A99 RID: 68249 RVA: 0x000A6172 File Offset: 0x000A4372
	public void GBOLAOBGLIH()
	{
		Singleton<GameManager>.Instance.CKMMHJLDADB(Singleton<GameManager>.Instance.CreateServerURL("float,10"), false);
	}

	// Token: 0x06010A9A RID: 68250 RVA: 0x00573444 File Offset: 0x00571644
	private void KOMOKHKMDGA()
	{
		this.DPGILDLHMLM();
		IEnumerator enumerator = Camera.main.gameObject.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform = (Transform)obj;
				if (transform.name == "_InvViewProj")
				{
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.caretGameObject);
		gameObject.name = "CameraFilterPack_3D_Matrix1";
		gameObject.transform.SetParent(Camera.main.gameObject.transform);
		gameObject.transform.localPosition = new Vector3(1026f, 778f, 922f);
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator3 = eventsCanvas.grid.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					object obj2 = enumerator3.Current;
					Transform transform2 = (Transform)obj2;
					UnityEngine.Object.Destroy(transform2.gameObject);
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = (enumerator3 as IDisposable)) != null)
				{
					disposable2.Dispose();
				}
			}
		}
		int num = 1;
		while ((float)num < this.editedMapData.musicTime)
		{
			foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridGameObject);
				gameObject2.transform.SetParent(eventsCanvas2.grid);
				gameObject2.transform.localPosition = new Vector3((float)num, 1966f, 395f);
				gameObject2.name = "OneHand";
			}
			num += 0;
		}
	}

	// Token: 0x06010A9B RID: 68251 RVA: 0x000A618E File Offset: 0x000A438E
	public void DNBGNJFJAMB()
	{
		Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
		Singleton<EditorArcsSelector>.Instance.GOCHMGBLMNE(this.currentTime);
		Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("Fade", false);
	}

	// Token: 0x06010A9C RID: 68252 RVA: 0x0057367C File Offset: 0x0057187C
	private IEnumerator PPEKKHNBMIH()
	{
		yield return new WaitForSeconds(0.5f);
		Singleton<UI>.Instance.SwitchView("StartCanvas", 0.2f);
		yield break;
	}

	// Token: 0x06010A9D RID: 68253 RVA: 0x00573690 File Offset: 0x00571890
	private void EHEAELMGGIH()
	{
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (!this.GPNKNBLBFOD.isEditing && this.currentState == MapEditor.EditorState.MapLoaded)
		{
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
				{
					this.zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 0.2f;
				}
				else
				{
					this.NLJJIAIEIDH(-Input.mouseScrollDelta.y * Camera.main.orthographicSize * 0.2f, false);
				}
			}
			if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl) && !flag)
			{
				if (Input.GetKeyDown(KeyCode.Space))
				{
					this.TogglePlay();
				}
				if (Input.GetKeyDown(KeyCode.R))
				{
					this.ToggleRecord();
				}
				if (Input.GetKeyDown(KeyCode.Delete))
				{
					this.OnDeleteButton();
				}
				if (Input.GetKeyDown(KeyCode.G))
				{
					this.Slowmo();
				}
				if (Input.GetKeyDown(KeyCode.B))
				{
					this.SetBPMEnabled(!this.useBPMSnap);
					this.useBpmToggle.isOn = this.useBPMSnap;
				}
				if (Input.GetKeyDown(KeyCode.H))
				{
					this.SpeedUp();
				}
				if (Input.GetKeyDown(KeyCode.Tab))
				{
					this.SwichCanvas();
				}
			}
		}
		if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
		{
			if (Input.GetKeyDown(KeyCode.Z))
			{
				Singleton<EditorHistoryHandler>.Instance.Undo();
			}
			if (Input.GetKeyDown(KeyCode.Y))
			{
				Singleton<EditorHistoryHandler>.Instance.Redo();
			}
			if (this.currentState == MapEditor.EditorState.MapLoaded && !flag)
			{
				if (Input.GetKeyDown(KeyCode.A))
				{
					Singleton<EditorArcsSelector>.Instance.SelectAll();
				}
				if (Input.GetKeyDown(KeyCode.C))
				{
					Singleton<EditorArcsSelector>.Instance.SaveSelectedToMemory();
				}
				if (Input.GetKeyDown(KeyCode.V))
				{
					Singleton<EditorArcsSelector>.Instance.PasteFromMemory(this.currentTime);
				}
				if (Input.GetMouseButtonDown(2))
				{
					this.SetZoom(5f);
				}
				if (Input.GetKeyDown(KeyCode.E))
				{
					this.OnEventConfigButton();
				}
			}
		}
		if (!this.isRecording && !this.GPNKNBLBFOD.isEditing && !flag)
		{
			if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					this.OnAddButton(0);
				}
				if (Input.GetKeyDown(KeyCode.C))
				{
					this.OnAddButton(1);
				}
			}
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				this.NLJJIAIEIDH(-0.1f * Camera.main.orthographicSize, false);
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				this.NLJJIAIEIDH(0.1f * Camera.main.orthographicSize, false);
			}
			if (Input.GetKeyDown(KeyCode.UpArrow) && this.currentEventsCanvasId < this.eventsCanvases.Count - 1)
			{
				this.currentEventsCanvasId++;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(false);
				}
			}
			if (Input.GetKeyDown(KeyCode.DownArrow) && this.currentEventsCanvasId > 0)
			{
				this.currentEventsCanvasId--;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(false);
				}
			}
		}
	}

	// Token: 0x06010A9E RID: 68254 RVA: 0x00573A14 File Offset: 0x00571C14
	private void DBMOMMPLINJ()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		using (List<string>.Enumerator enumerator = this.editedMapData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				MapEditor.CFBBHNAOKPA cfbbhnaokpa = new MapEditor.CFBBHNAOKPA();
				cfbbhnaokpa.IEOKJCPAOHL = enumerator.Current;
				cfbbhnaokpa.ADPIKBBAKHP = this;
				MapEditor.NDFEKONPOMG ndfekonpomg = new MapEditor.NDFEKONPOMG();
				ndfekonpomg.KHCIOAJAKOO = cfbbhnaokpa;
				ndfekonpomg.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				ndfekonpomg.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				ndfekonpomg.OBFJPHLBFOL.transform.localScale = new Vector3(1007f, 543f, 930f);
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = cfbbhnaokpa.IEOKJCPAOHL;
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(ndfekonpomg.OFLDIMDDLHM));
				num++;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(213f, 708f, 1228f);
	}

	// Token: 0x06010A9F RID: 68255 RVA: 0x00573BE0 File Offset: 0x00571DE0
	public void FindNearestEvent(bool OAKJLAFMOHO = false)
	{
		this.editingEventGO = this.KIDAPPHEPBE();
		if (this.editingEventGO && (OAKJLAFMOHO || this.editingEventGO != this.AEAKHCLJFDH))
		{
			this.GPNKNBLBFOD.Load(this.editingEventGO.GetComponent<EditorEvent>());
			this.AEAKHCLJFDH = this.editingEventGO;
		}
	}

	// Token: 0x06010AA0 RID: 68256 RVA: 0x00573C48 File Offset: 0x00571E48
	private IEnumerator DOIOKHEFLKL()
	{
		string text = GameObject.Find("MapFolderInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		string result2 = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		int acodlkjmcjf = (int)GameObject.Find("NewMapHandsCountSlider").GetComponent<Slider>().value;
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Helpers.ObtainAchievement(10);
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text2 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text2);
			Debug.Log("[MapEditor] Created new map: " + text2);
			yield return base.StartCoroutine(this.UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), result, result2, text2, true, acodlkjmcjf));
			this.IIIGPJIJHKD(text2);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010AA1 RID: 68257 RVA: 0x00573C64 File Offset: 0x00571E64
	public IEnumerator Save(bool BLIOAGPOANM = true, bool KIIAKJPJDKB = true)
	{
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		}
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData = this.GetEditedData(KIIAKJPJDKB);
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		Debug.Log("[MapEditor] Exported to " + fullLevelPath);
		Singleton<EditorHistoryHandler>.Instance.OnMapSaved();
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010AA2 RID: 68258 RVA: 0x00573C90 File Offset: 0x00571E90
	public void NMMIJMBOHNG(string DPNHODJHGJL)
	{
		try
		{
			float dpnhodjhgjl = float.Parse(DPNHODJHGJL, ~NumberStyles.AllowLeadingSign);
			this.LOLIHNOEGLJ(dpnhodjhgjl);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06010AA3 RID: 68259 RVA: 0x00573CCC File Offset: 0x00571ECC
	private void AJEFOEJANDB(float EHHBHEJBHNG)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, new List<string>
		{
			"checkpoint"
		});
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "checkpoint";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added checkpoint", false);
		this.UpdateBottomBar();
		this.FindNearestEvent(true);
	}

	// Token: 0x06010AA4 RID: 68260 RVA: 0x000A61BF File Offset: 0x000A43BF
	public void HDOAGPJOGLL()
	{
		base.StartCoroutine(this.DOIOKHEFLKL());
	}

	// Token: 0x06010AA5 RID: 68261 RVA: 0x000A61CE File Offset: 0x000A43CE
	public void OnLoadMapButton()
	{
		base.StartCoroutine(this.AMAENBAABIN());
	}

	// Token: 0x06010AA6 RID: 68262 RVA: 0x000A61DD File Offset: 0x000A43DD
	public void OnCopyButton()
	{
		if (Singleton<EditorArcsSelector>.Instance.selectedunits.Count > 0)
		{
			Singleton<EditorArcsSelector>.Instance.SaveSelectedToMemory();
		}
	}

	// Token: 0x06010AA7 RID: 68263 RVA: 0x00573D68 File Offset: 0x00571F68
	private void BLCIBGFKBKD(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Singleton<MessageBoxPanel>.Instance.BIGHIEJMHHA("_Value5", ",", null, true, true, 1702f);
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != (EResult)0)
		{
			Singleton<MessageBoxPanel>.Instance.HLEOBMODPLO("CheckCombo", "_LightIntensity", null, true, false, 1478f);
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		else
		{
			Singleton<GameManager>.Instance.GMOJGDKBHEL("_ScreenResolution" + NPIKJHPJIEA.m_nPublishedFileId, false);
			Debug.Log("[DiscordController] Init");
			Singleton<MessageBoxPanel>.Instance.DKGAEEALMLE("SetEnvSpriteImage", "_Value", null, true, true, 1769f);
			if (RanksSystem.IsOfficial(NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, false))
			{
				string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
				string ddaomdpaiep = fullLevelPath + "settings.arcsdestroydelay" + Helpers.levelConfigFileName;
				int mapMaxScore = Helpers.GetMapMaxScore(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
				float mapDifficulty = Helpers.GetMapDifficulty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
				base.StartCoroutine(Singleton<RanksSystem>.Instance.MGPMNKJDGAC(string.Empty + NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, Helpers.CalculateMD5(ddaomdpaiep), mapDifficulty, mapMaxScore));
			}
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		this.PAODIJKEBCA = false;
	}

	// Token: 0x06010AA8 RID: 68264 RVA: 0x00573EE0 File Offset: 0x005720E0
	public void LEGBBDJECDA()
	{
		string text = string.Empty;
		if (!this.IsMapLoaded())
		{
			if (LocalizationService.Instance && LocalizationService.Instance.inited)
			{
				text = LocalizationService.Instance.GAAFIKGPNAO("maps.");
			}
		}
		else
		{
			object[] array = new object[]
			{
				this.CAFHKDIIDEE,
				"IncorrectHitsScoreText",
				null,
				Singleton<EditorHistoryHandler>.Instance.GetCurrentStateString()
			};
			array[1] = "PunRespawn";
			array[3] = this.editedMapData.events.Count;
			text = string.Concat(array);
		}
		this.statusBarText.text = text;
		if (GameObject.Find("LivesSlider"))
		{
			GameObject.Find("OneHand").GetComponent<Image>().sprite = ((!this.audioSampler.audioSources[1].isPlaying) ? this.playImage : this.pauseImage);
		}
		if (GameObject.Find("_ReflectionTexture2"))
		{
			Button component = GameObject.Find("_Value4").GetComponent<Button>();
			ColorBlock colors = component.colors;
			colors.normalColor = (this.isRecording ? Color.red : Color.black);
			colors.highlightedColor = Helpers.HexToColor(" respawn: ");
			colors.disabledColor = Color.black;
			colors.pressedColor = Helpers.HexToColor("RoomNameText");
			component.colors = colors;
		}
	}

	// Token: 0x06010AA9 RID: 68265 RVA: 0x000A61FE File Offset: 0x000A43FE
	public void LOLIHNOEGLJ(float DPNHODJHGJL)
	{
		this.BPM = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010AAA RID: 68266 RVA: 0x000A620D File Offset: 0x000A440D
	public void AddNewUnlockCondition()
	{
		this.editedMapData.unlockConditions.Add(string.Empty);
		this.PLICILPAOJJ();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions", false);
	}

	// Token: 0x06010AAB RID: 68267 RVA: 0x000A604D File Offset: 0x000A424D
	public void CNFIMHHGGGI()
	{
		this.BLLONNLMMNA();
	}

	// Token: 0x06010AAC RID: 68268 RVA: 0x000A623A File Offset: 0x000A443A
	public void KBNPAABILBK(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.GKGAABCOKHJ(HMGBJCGOLMI));
	}

	// Token: 0x06010AAD RID: 68269 RVA: 0x000A60E4 File Offset: 0x000A42E4
	public void EIBIDEGADAH(bool DPNHODJHGJL)
	{
		this.useBPMSnap = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010AAE RID: 68270 RVA: 0x000A624A File Offset: 0x000A444A
	public void OnBackToEditorButton()
	{
		this.currentState = MapEditor.EditorState.MapLoaded;
		Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		if (this.eventConfigCanvas.activeSelf)
		{
			this.FindNearestEvent(true);
		}
	}

	// Token: 0x06010AAF RID: 68271 RVA: 0x0057405C File Offset: 0x0057225C
	private void CLFPFIMABIH(float EHHBHEJBHNG, bool BNLKFNOIDHH = true)
	{
		if (this.MAONHJDBGAH())
		{
			float num;
			if (BNLKFNOIDHH)
			{
				num = EHHBHEJBHNG * this.audioSampler.audioSources[1].clip.length;
			}
			else
			{
				num = this.currentTime + EHHBHEJBHNG;
			}
			if (num < 784f)
			{
				num = 625f;
			}
			if (num >= this.audioSampler.audioSources[1].clip.length)
			{
				num = this.audioSampler.audioSources[1].clip.length;
			}
			this.currentTime = num;
			if (this.eventConfigCanvas.activeSelf)
			{
				this.FindNearestEvent(true);
			}
			if (this.isPlaying)
			{
				this.audioSampler.audioSources[1].time = this.currentTime;
			}
		}
	}

	// Token: 0x06010AB0 RID: 68272 RVA: 0x000A627E File Offset: 0x000A447E
	public void PDILMECHCMI()
	{
		this.currentState = (MapEditor.EditorState)4;
		Singleton<UI>.Instance.GNPMFBMPDPO("#", 1933f);
	}

	// Token: 0x06010AB1 RID: 68273 RVA: 0x000A61FE File Offset: 0x000A43FE
	public void SetBPM(float DPNHODJHGJL)
	{
		this.BPM = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010AB2 RID: 68274 RVA: 0x00574140 File Offset: 0x00572340
	private void BANNGFMGKIK()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		using (List<string>.Enumerator enumerator = this.editedMapData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				MapEditor.CFBBHNAOKPA cfbbhnaokpa = new MapEditor.CFBBHNAOKPA();
				cfbbhnaokpa.IEOKJCPAOHL = enumerator.Current;
				cfbbhnaokpa.ADPIKBBAKHP = this;
				MapEditor.NDFEKONPOMG ndfekonpomg = new MapEditor.NDFEKONPOMG();
				ndfekonpomg.KHCIOAJAKOO = cfbbhnaokpa;
				ndfekonpomg.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				ndfekonpomg.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				ndfekonpomg.OBFJPHLBFOL.transform.localScale = new Vector3(1199f, 37f, 395f);
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = cfbbhnaokpa.IEOKJCPAOHL;
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(ndfekonpomg.EFAPFFFGOOA));
				num += 0;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(1100f, 1332f, 1646f);
	}

	// Token: 0x06010AB3 RID: 68275 RVA: 0x0057430C File Offset: 0x0057250C
	public void TogglePlay()
	{
		Singleton<UI>.Instance.ClearSelection();
		this.isPlaying = !this.isPlaying;
		this.audioSampler.audioSources[1].time = this.currentTime;
		if (this.isPlaying)
		{
			this.audioSampler.audioSources[1].Play();
		}
		else
		{
			this.audioSampler.audioSources[1].Pause();
		}
		this.UpdateBottomBar();
	}

	// Token: 0x06010AB4 RID: 68276 RVA: 0x000A629B File Offset: 0x000A449B
	public void FOGPBLLNKND()
	{
		this.currentState = (MapEditor.EditorState)5;
		Singleton<UI>.Instance.IGLHHNJFLDO("_ScreenResolution", 494f);
	}

	// Token: 0x06010AB5 RID: 68277 RVA: 0x00574390 File Offset: 0x00572590
	public void MMOKKAPFGAK()
	{
		this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.PFIPOJIIODP));
		this.KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.BMDDFOKBIAK));
		Singleton<GameManager>.Instance.INLEIPHNJPF("[PlayerController] ", "default", null, null, 0, 1);
		this.Reset();
		base.StartCoroutine(this.PPEKKHNBMIH());
	}

	// Token: 0x06010AB6 RID: 68278 RVA: 0x005743F8 File Offset: 0x005725F8
	public void Reset()
	{
		Debug.Log("[MapEditor] Reset");
		Singleton<EditorHistoryHandler>.Instance.Clear();
		this.currentState = MapEditor.EditorState.Init;
		this.DMOOGKMALBD = false;
		this.CAFHKDIIDEE = null;
		this.editedMapData = null;
		this.isRecording = false;
		this.PAODIJKEBCA = false;
		this.isPlaying = false;
		this.currentTime = 0f;
		this.currentEventsCanvasId = 0;
		this.GPNKNBLBFOD = base.GetComponent<CustomEventEditor>();
		this.editingEventGO = null;
		this.AEAKHCLJFDH = null;
		DropDownList component = this.eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>();
		component.Start();
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.eventConfigCanvas, false, null, true, 0f, true));
		this.UpdateTopMenu();
		this.UpdateBottomBar();
		this.currentTimeText.text = "0.00:0.00";
	}

	// Token: 0x06010AB7 RID: 68279 RVA: 0x000A623A File Offset: 0x000A443A
	public void OnUpdateMapMainResourceButton(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.GKGAABCOKHJ(HMGBJCGOLMI));
	}

	// Token: 0x06010AB8 RID: 68280 RVA: 0x005744D4 File Offset: 0x005726D4
	public void LKBLKOFMLEE(List<string> NKEHMBLLEMH)
	{
		if (this.editingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = this.editingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(this.eventConfigCanvas.transform.Find("_Parameter").GetComponent<InputField>().text, NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			this.editingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			this.editingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			this.editingEventGO.GetComponent<EditorEvent>().CMHOENHNEEL();
			this.eventConfigCanvas.transform.Find("#onrankchangedowntext").GetComponent<InputField>().text = string.Empty + this.editingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			this.FindNearestEvent(false);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("_TimeX", false);
		}
	}

	// Token: 0x06010AB9 RID: 68281 RVA: 0x005745D0 File Offset: 0x005727D0
	public void IDPOMAAHDBP()
	{
		if (Singleton<GameManager>.Instance.GetCurrentBanLevel() <= 0)
		{
			base.StartCoroutine(this.ONJIIJDEFOM());
		}
		else
		{
			RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string[] array = new string[0];
			array[0] = "_Distortion";
			array[0] = actveBan.bantype.ToString().ToLower();
			array[3] = "No info";
			array[7] = actveBan.reason;
			array[4] = "false";
			array[0] = actveBan.bantype.ToString().ToLower();
			array[7] = "SingleplayerButton";
			array[7] = ((!(actveBan.until == "_Value1")) ? actveBan.until : "_Amount");
			instance.IINDNBDIOMJ(string.Concat(array), "settings.disablestoryboard", null, false, false, 1106f);
		}
	}

	// Token: 0x06010ABA RID: 68282 RVA: 0x000A62B8 File Offset: 0x000A44B8
	private void IIIGPJIJHKD(string NBGPBKCPFDN)
	{
		this.Reset();
		this.CAFHKDIIDEE = NBGPBKCPFDN;
		base.StartCoroutine(this.GOGFAHNINFB());
	}

	// Token: 0x06010ABB RID: 68283 RVA: 0x005746B0 File Offset: 0x005728B0
	private void BPOJHBIEMOJ()
	{
		this.DPGILDLHMLM();
		IEnumerator enumerator = Camera.main.gameObject.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform = (Transform)obj;
				if (transform.name == "caret")
				{
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.caretGameObject);
		gameObject.name = "caret";
		gameObject.transform.SetParent(Camera.main.gameObject.transform);
		gameObject.transform.localPosition = new Vector3(0f, 0f, 1f);
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator3 = eventsCanvas.grid.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					object obj2 = enumerator3.Current;
					Transform transform2 = (Transform)obj2;
					UnityEngine.Object.Destroy(transform2.gameObject);
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = (enumerator3 as IDisposable)) != null)
				{
					disposable2.Dispose();
				}
			}
		}
		int num = 0;
		while ((float)num < this.editedMapData.musicTime)
		{
			foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridGameObject);
				gameObject2.transform.SetParent(eventsCanvas2.grid);
				gameObject2.transform.localPosition = new Vector3((float)num, 0f, 0f);
				gameObject2.name = "grid";
			}
			num++;
		}
	}

	// Token: 0x06010ABC RID: 68284 RVA: 0x005748E8 File Offset: 0x00572AE8
	public void FLKOHLGNALL(List<string> NKEHMBLLEMH)
	{
		if (this.editingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = this.editingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(this.eventConfigCanvas.transform.Find("CameraFilterPack_TV_Noise3").GetComponent<InputField>().text, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			this.editingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			this.editingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			this.editingEventGO.GetComponent<EditorEvent>().LPJFCLNOFAF();
			this.eventConfigCanvas.transform.Find("Ev Destroy Failed. Could not find PhotonView with instantiationId ").GetComponent<InputField>().text = string.Empty + this.editingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			this.FindNearestEvent(false);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_PosX", true);
		}
	}

	// Token: 0x06010ABD RID: 68285 RVA: 0x005749E4 File Offset: 0x00572BE4
	public void Start()
	{
		this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.PFIPOJIIODP));
		this.KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.BMDDFOKBIAK));
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Map Editor", "Creating awesome maps", null, null, 0, 0);
		this.Reset();
		base.StartCoroutine(this.PPEKKHNBMIH());
	}

	// Token: 0x06010ABE RID: 68286 RVA: 0x00574A4C File Offset: 0x00572C4C
	public void OnAddButton(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			if (this.eventsCanvases[this.currentEventsCanvasId].forType == MapEditor.EventType.Gameplay)
			{
				this.AddNewEvent(this.currentTime, new List<string>
				{
					"SpawnObj",
					"[Up]"
				}, true);
			}
			else
			{
				this.AddNewEvent(this.currentTime, new List<string>
				{
					"ShowTitle",
					",0"
				}, true);
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			this.AJEFOEJANDB(this.currentTime);
		}
	}

	// Token: 0x06010ABF RID: 68287 RVA: 0x00574AE8 File Offset: 0x00572CE8
	public IEnumerator ConfirmExiting()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#exitmapeditor", "#yes", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			if (!this.IsMapLoaded())
			{
				Time.timeScale = 1f;
				ResourcesManager.UnloadResources(false);
				SceneManager.LoadScene("MenuScene");
			}
			else
			{
				if (Singleton<EditorHistoryHandler>.Instance.savedHistoryState != Singleton<EditorHistoryHandler>.Instance.state)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#savemapchanges?", "#yes", null, "#no", null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						yield return base.StartCoroutine(this.Save(true, true));
					}
				}
				Time.timeScale = 1f;
				ResourcesManager.UnloadResources(false);
				SceneManager.LoadScene("MenuScene");
			}
		}
		yield break;
	}

	// Token: 0x06010AC0 RID: 68288 RVA: 0x00574B04 File Offset: 0x00572D04
	public void LEAHIBJDMBI()
	{
		if (!this.PAODIJKEBCA && Input.GetKeyDown(KeyCode.Semicolon))
		{
			this.OnExitButton();
		}
		if (this.PAODIJKEBCA)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(this.FHKGDJDOKNB, out num, out num2);
			float iadppjhimbg = num / num2;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				Singleton<MessageBoxPanel>.Instance.CIOKBENBFPJ("PunRespawn with Position.", "Gameplay/sun", null, false, true, 798f);
				this.PAODIJKEBCA = false;
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				Singleton<MessageBoxPanel>.Instance.DPFKHGBCDFH("#no", "CameraFilterPack/Edge_Edge_filter", null, false, false, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				Singleton<MessageBoxPanel>.Instance.JJEOAFDDLHK("skin.", "_Threshold", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				Singleton<MessageBoxPanel>.Instance.JPHEAJOLIGK("_TimeX", "maps.", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				Singleton<MessageBoxPanel>.Instance.JPHEAJOLIGK("Outdated version. Please restart the game to get lastest updates.", "{0:0.0} ms ({1:0.} fps)", null, true, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				Singleton<MessageBoxPanel>.Instance.POHMPIDHJII("Received RPC: ", "Connected to masterserver.", null, false, false, iadppjhimbg);
				break;
			}
		}
		if (!this.MAONHJDBGAH())
		{
			this.currentTimeText.text = "Editor/";
		}
		else
		{
			this.currentTimeText.text = this.currentTime.ToString("LevelInfoInputField") + "CameraFilterPack_Glasses_On3" + this.audioSampler.audioSources[0].clip.length.ToString("_Value2");
			this.currentTimeSlider.value = this.currentTime;
			if (this.isPlaying)
			{
				if (this.audioSampler.audioSources[1].isPlaying)
				{
					this.currentTime = this.audioSampler.audioSources[0].time;
					if (this.eventConfigCanvas.activeSelf)
					{
						this.FindNearestEvent(false);
					}
				}
				else
				{
					this.isPlaying = false;
					this.LEGBBDJECDA();
				}
			}
			this.EHEAELMGGIH();
		}
	}

	// Token: 0x06010AC1 RID: 68289 RVA: 0x000A62D4 File Offset: 0x000A44D4
	public void OnManualButton()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/files/editor_manual.pdf"), true);
	}

	// Token: 0x06010AC2 RID: 68290 RVA: 0x000A62F0 File Offset: 0x000A44F0
	public void NFDNABGCANE()
	{
		Singleton<UI>.Instance.GNPMFBMPDPO("Deleted event", 1067f);
	}

	// Token: 0x06010AC3 RID: 68291 RVA: 0x000A6306 File Offset: 0x000A4506
	[CompilerGenerated]
	private void MOFDPGHNDMO()
	{
		this.AddNewUnlockCondition();
	}

	// Token: 0x06010AC4 RID: 68292 RVA: 0x000A630E File Offset: 0x000A450E
	public void HLMPHHHPDCO()
	{
		Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
		Singleton<EditorArcsSelector>.Instance.MFIMPKCHFOG(this.currentTime);
		Singleton<EditorHistoryHandler>.Instance.KMIIHCELMAG("0 - sun, 1 - satellite, 2 - particles emitter", false);
	}

	// Token: 0x06010AC5 RID: 68293 RVA: 0x00574D20 File Offset: 0x00572F20
	private IEnumerator NODFLLCDCOH(string JMMILEFMACB)
	{
		string text = JMMILEFMACB + "_copy" + UnityEngine.Random.Range(1000000, 10000000);
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Singleton<MapsSystem>.Instance.GetMapData(JMMILEFMACB).fullLevelPath, Helpers.GetDirectory("Editor/" + text), true);
			string text2 = Helpers.GetDirectory("Editor/" + text) + "/" + Helpers.workshopConfigFileName;
			if (new FileInfo(text2).Exists)
			{
				File.Delete(text2);
			}
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text3 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text3);
			Debug.Log("[MapEditor] Importing map: " + text3);
			yield return base.StartCoroutine(this.UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), null, null, text3, false, 1));
			this.IIIGPJIJHKD(text3);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010AC6 RID: 68294 RVA: 0x000A633F File Offset: 0x000A453F
	public void ScrollTime(float EHHBHEJBHNG)
	{
		Singleton<UI>.Instance.ClearSelection();
		this.NLJJIAIEIDH(EHHBHEJBHNG, true);
	}

	// Token: 0x06010AC7 RID: 68295 RVA: 0x000A6353 File Offset: 0x000A4553
	public void NOFAJCCJPFO()
	{
		base.StartCoroutine(this.AJENEGMPAOD());
	}

	// Token: 0x06010AC8 RID: 68296 RVA: 0x00574D44 File Offset: 0x00572F44
	public void ToggleVolume()
	{
		this.DMOOGKMALBD = !this.DMOOGKMALBD;
		this.volumePanel.GetComponentInChildren<Slider>().value = base.GetComponent<VolumeSettings>().GetEditorVolume();
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.volumePanel, this.DMOOGKMALBD, null, true, 0.2f, true));
		Singleton<UI>.Instance.ClearSelection();
	}

	// Token: 0x06010AC9 RID: 68297 RVA: 0x000A6362 File Offset: 0x000A4562
	public void OnPasteButton()
	{
		Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
		Singleton<EditorArcsSelector>.Instance.PasteFromMemory(this.currentTime);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Delete events", false);
	}

	// Token: 0x06010ACA RID: 68298 RVA: 0x00574DAC File Offset: 0x00572FAC
	public void OEJEMJAJGLK(List<string> NKEHMBLLEMH)
	{
		if (this.editingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = this.editingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(this.eventConfigCanvas.transform.Find("caret").GetComponent<InputField>().text, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			this.editingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			this.editingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			this.editingEventGO.GetComponent<EditorEvent>().LPJFCLNOFAF();
			this.eventConfigCanvas.transform.Find("EnableRankingToggle").GetComponent<InputField>().text = string.Empty + this.editingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			this.FindNearestEvent(false);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_Value2", false);
		}
	}

	// Token: 0x06010ACB RID: 68299 RVA: 0x00574EA8 File Offset: 0x005730A8
	private void PFFNMBDHDLN()
	{
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (!this.GPNKNBLBFOD.isEditing && this.currentState == MapEditor.EditorState.MapLoaded)
		{
			if (Input.mouseScrollDelta.y != 504f)
			{
				if (Input.GetKey((KeyCode)(-76)) || Input.GetKey((KeyCode)182))
				{
					this.zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 1633f;
				}
				else
				{
					this.NLJJIAIEIDH(-Input.mouseScrollDelta.y * Camera.main.orthographicSize * 1854f, true);
				}
			}
			if (!Input.GetKey((KeyCode)10) && !Input.GetKey(KeyCode.C) && !flag)
			{
				if (Input.GetKeyDown((KeyCode)(-81)))
				{
					this.TogglePlay();
				}
				if (Input.GetKeyDown((KeyCode)14))
				{
					this.GKGGAIFBLNN();
				}
				if (Input.GetKeyDown((KeyCode)(-103)))
				{
					this.FDJMEIAKLOF();
				}
				if (Input.GetKeyDown((KeyCode)(-49)))
				{
					this.Slowmo();
				}
				if (Input.GetKeyDown((KeyCode)(-31)))
				{
					this.IMMHGJFBGAJ(!this.useBPMSnap);
					this.useBpmToggle.isOn = this.useBPMSnap;
				}
				if (Input.GetKeyDown((KeyCode)(-37)))
				{
					this.SpeedUp();
				}
				if (Input.GetKeyDown(KeyCode.LeftBracket))
				{
					this.SwichCanvas();
				}
			}
		}
		if (Input.GetKey((KeyCode)(-27)) || Input.GetKey((KeyCode)(-6)))
		{
			if (Input.GetKeyDown((KeyCode)67))
			{
				Singleton<EditorHistoryHandler>.Instance.BEOOOJABPAB();
			}
			if (Input.GetKeyDown((KeyCode)(-3)))
			{
				Singleton<EditorHistoryHandler>.Instance.GKNOIFNFOCC();
			}
			if (this.currentState == MapEditor.EditorState.Init && !flag)
			{
				if (Input.GetKeyDown((KeyCode)(-44)))
				{
					Singleton<EditorArcsSelector>.Instance.AODGPNKDDOO();
				}
				if (Input.GetKeyDown(KeyCode.Question))
				{
					Singleton<EditorArcsSelector>.Instance.PEBAJGKNMFB();
				}
				if (Input.GetKeyDown((KeyCode)(-60)))
				{
					Singleton<EditorArcsSelector>.Instance.MFIMPKCHFOG(this.currentTime);
				}
				if (Input.GetMouseButtonDown(4))
				{
					this.SetZoom(710f);
				}
				if (Input.GetKeyDown((KeyCode)(-60)))
				{
					this.HBDKEOFBGHE();
				}
			}
		}
		if (!this.isRecording && !this.GPNKNBLBFOD.isEditing && !flag)
		{
			if (!Input.GetKey((KeyCode)(-94)) && !Input.GetKey((KeyCode)(-151)))
			{
				if (Input.GetKeyDown(KeyCode.Greater))
				{
					this.OnAddButton(1);
				}
				if (Input.GetKeyDown((KeyCode)(-68)))
				{
					this.OnAddButton(1);
				}
			}
			if (Input.GetKey((KeyCode)(-125)))
			{
				this.CLFPFIMABIH(943f * Camera.main.orthographicSize, false);
			}
			if (Input.GetKey((KeyCode)(-66)))
			{
				this.NLJJIAIEIDH(393f * Camera.main.orthographicSize, false);
			}
			if (Input.GetKeyDown((KeyCode)(-142)) && this.currentEventsCanvasId < this.eventsCanvases.Count - 0)
			{
				this.currentEventsCanvasId++;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(true);
				}
			}
			if (Input.GetKeyDown((KeyCode)(-152)) && this.currentEventsCanvasId > 1)
			{
				this.currentEventsCanvasId -= 0;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(true);
				}
			}
		}
	}

	// Token: 0x06010ACC RID: 68300 RVA: 0x0057522C File Offset: 0x0057342C
	private void NMEJKNDPLHH(float EHHBHEJBHNG)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.JCNHFKOAHHH(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, new List<string>
		{
			"_MainTex"
		});
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "0";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("CameraFilterPack/Lut_TestMode", false);
		this.UpdateBottomBar();
		this.FindNearestEvent(false);
	}

	// Token: 0x06010ACD RID: 68301 RVA: 0x005752C8 File Offset: 0x005734C8
	private void HNIOIOCLAOI(float EHHBHEJBHNG)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.JCNHFKOAHHH(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, new List<string>
		{
			".progress"
		});
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "_NoiseAmount";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().CMNPEMEIJEJ();
		Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("BloomShaderValueSlider", false);
		this.LEGBBDJECDA();
		this.FindNearestEvent(true);
	}

	// Token: 0x06010ACE RID: 68302 RVA: 0x000A616A File Offset: 0x000A436A
	public void AJDJEKDDIPE()
	{
		this.LCJDCFFEMLP();
	}

	// Token: 0x06010ACF RID: 68303 RVA: 0x000A60E4 File Offset: 0x000A42E4
	public void SetBPMEnabled(bool DPNHODJHGJL)
	{
		this.useBPMSnap = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010AD0 RID: 68304 RVA: 0x000A6393 File Offset: 0x000A4593
	public void CPCJJBBGEFC()
	{
		Singleton<GameManager>.Instance.GMOJGDKBHEL(Singleton<GameManager>.Instance.JJGKGCBCGGD("ChallengesButton"), false);
	}

	// Token: 0x06010AD1 RID: 68305 RVA: 0x000A63AF File Offset: 0x000A45AF
	public void JBLIHBOEHHB()
	{
		this.currentState = (MapEditor.EditorState)4;
		Singleton<UI>.Instance.MJLEAPCLIEK("_Value2", 1374f);
	}

	// Token: 0x06010AD2 RID: 68306 RVA: 0x00574AE8 File Offset: 0x00572CE8
	public IEnumerator PMCEMFBDIBD()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#exitmapeditor", "#yes", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			if (!this.IsMapLoaded())
			{
				Time.timeScale = 1f;
				ResourcesManager.UnloadResources(false);
				SceneManager.LoadScene("MenuScene");
			}
			else
			{
				if (Singleton<EditorHistoryHandler>.Instance.savedHistoryState != Singleton<EditorHistoryHandler>.Instance.state)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#savemapchanges?", "#yes", null, "#no", null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						yield return base.StartCoroutine(this.Save(true, true));
					}
				}
				Time.timeScale = 1f;
				ResourcesManager.UnloadResources(false);
				SceneManager.LoadScene("MenuScene");
			}
		}
		yield break;
	}

	// Token: 0x06010AD3 RID: 68307 RVA: 0x000A60E4 File Offset: 0x000A42E4
	public void NJDKNOJIIHN(bool DPNHODJHGJL)
	{
		this.useBPMSnap = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010AD4 RID: 68308 RVA: 0x00573C48 File Offset: 0x00571E48
	private IEnumerator OECGEKPJPCB()
	{
		string text = GameObject.Find("MapFolderInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		string result2 = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		int acodlkjmcjf = (int)GameObject.Find("NewMapHandsCountSlider").GetComponent<Slider>().value;
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Helpers.ObtainAchievement(10);
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text2 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text2);
			Debug.Log("[MapEditor] Created new map: " + text2);
			yield return base.StartCoroutine(this.UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), result, result2, text2, true, acodlkjmcjf));
			this.IIIGPJIJHKD(text2);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010AD5 RID: 68309 RVA: 0x00575364 File Offset: 0x00573564
	public void FDJMEIAKLOF()
	{
		if (Singleton<EditorArcsSelector>.Instance.selectedunits.Count > 0)
		{
			foreach (GameObject obj in Singleton<EditorArcsSelector>.Instance.selectedunits)
			{
				UnityEngine.Object.Destroy(obj);
			}
			Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM(" = ", false);
		}
	}

	// Token: 0x06010AD6 RID: 68310 RVA: 0x005753F8 File Offset: 0x005735F8
	public void UpdateTopMenu()
	{
		Debug.Log("[MapEditor] Updating top menu");
		bool flag = this.IsMapLoaded();
		bool flag2 = this.currentState == MapEditor.EditorState.Busy;
		this.topMenuPanel.transform.Find("FileMenu").GetComponent<Button>().interactable = !flag2;
		this.topMenuPanel.transform.Find("FileMenu").FindDeepChild("SaveMapButton").GetComponent<Button>().interactable = flag;
		this.topMenuPanel.transform.Find("FileMenu").FindDeepChild("PublishMapButton").GetComponent<Button>().interactable = flag;
		this.topMenuPanel.transform.Find("FileMenu").FindDeepChild("TestMapButton").GetComponent<Button>().interactable = flag;
		this.topMenuPanel.transform.Find("EditMenu").GetComponent<Button>().interactable = (flag && !flag2);
		this.topMenuPanel.transform.Find("EventMenu").GetComponent<Button>().interactable = (flag && !flag2);
		this.topMenuPanel.transform.Find("ViewMenu").GetComponent<Button>().interactable = (flag && !flag2);
		this.topMenuPanel.transform.Find("HelpMenu").GetComponent<Button>().interactable = !flag2;
	}

	// Token: 0x06010AD7 RID: 68311 RVA: 0x00575568 File Offset: 0x00573768
	public void OnEventConfigButton()
	{
		bool flag = !this.eventConfigCanvas.activeSelf;
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.eventConfigCanvas, flag, null, true, 0.2f, true));
		if (flag)
		{
			this.FindNearestEvent(false);
		}
		else
		{
			this.GPNKNBLBFOD.StopEditing();
			Singleton<UI>.Instance.ClearSelection();
		}
	}

	// Token: 0x06010AD8 RID: 68312 RVA: 0x005755CC File Offset: 0x005737CC
	public MapData GetEditedData(bool KIIAKJPJDKB = true)
	{
		this.editedMapData.name = this.configCanvas.transform.Find("Tab1Content").Find("LevelNameInputField").GetComponent<InputField>().text;
		this.editedMapData.info = this.configCanvas.transform.Find("Tab1Content").Find("LevelInfoInputField").GetComponent<InputField>().text;
		this.editedMapData.moreInfoURL = this.configCanvas.transform.Find("Tab1Content").Find("LevelURLInputField").GetComponent<InputField>().text;
		this.editedMapData.speed = (float)((int)this.configCanvas.transform.Find("Tab2Content").Find("SpeedSlider").GetComponent<Slider>().value);
		this.editedMapData.configVersion = (int)this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().value;
		this.editedMapData.lives = (int)this.configCanvas.transform.Find("Tab2Content").Find("LivesSlider").GetComponent<Slider>().value;
		this.editedMapData.maxLives = (int)this.configCanvas.transform.Find("Tab2Content").Find("MaxLivesSlider").GetComponent<Slider>().value;
		this.editedMapData.handCount = (int)this.configCanvas.transform.Find("Tab2Content").Find("HandsCountSlider").GetComponent<Slider>().value;
		this.editedMapData.environmentType = (int)this.configCanvas.transform.Find("Tab2Content").Find("EnvironmentSlider").GetComponent<Slider>().value;
		this.editedMapData.hidden = this.configCanvas.transform.Find("Tab2Content").Find("HiddenToggle").GetComponent<Toggle>().isOn;
		if (KIIAKJPJDKB)
		{
			this.editedMapData.musicTime = this.audioSampler.audioSources[1].clip.length;
		}
		this.editedMapData.tags = new List<string>();
		foreach (Toggle toggle in this.tagsScrollRectContent.GetComponentsInChildren<Toggle>())
		{
			if (toggle.isOn)
			{
				this.editedMapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (this.editedMapData.handCount == 1)
		{
			this.editedMapData.tags.Add("OneHand");
		}
		else if (this.editedMapData.handCount == 2)
		{
			this.editedMapData.tags.Add("TwoHands");
		}
		this.editedMapData.unlockConditions = new List<string>();
		foreach (InputField inputField in this.unlockConditionContent.GetComponentsInChildren<InputField>())
		{
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				this.editedMapData.unlockConditions.Add(inputField.text);
			}
		}
		this.editedMapData.events.Clear();
		if (this.editedMapData.configVersion >= 3)
		{
			MapData.EData edata = new MapData.EData();
			edata.events = new List<MapEvent>();
			for (int j = 0; j < this.eventsContainer.transform.childCount; j++)
			{
				if (this.eventsContainer.transform.GetChild(j).name == "event")
				{
					MapEvent item = new MapEvent(this.eventsContainer.transform.GetChild(j).GetComponent<EditorEvent>().mapEvent);
					this.editedMapData.events.Add(item);
				}
			}
			MapData mapData = this.editedMapData;
			IEnumerable<MapEvent> events = this.editedMapData.events;
			if (MapEditor.CLCBJCKCBDD == null)
			{
				MapEditor.CLCBJCKCBDD = new Func<MapEvent, float>(MapEditor.ABCOEBPCAJI);
			}
			mapData.events = events.OrderBy(MapEditor.CLCBJCKCBDD).ToList<MapEvent>();
			MapData.EData edata2 = edata;
			IEnumerable<MapEvent> events2 = edata.events;
			if (MapEditor.HCLEECLNOEA == null)
			{
				MapEditor.HCLEECLNOEA = new Func<MapEvent, float>(MapEditor.MMAGIMBKFLF);
			}
			edata2.events = events2.OrderBy(MapEditor.HCLEECLNOEA).ToList<MapEvent>();
			this.editedMapData.e = global::Console.Log(JsonConvert.SerializeObject(edata), Singleton<SaveSystem>.Instance.folder);
		}
		else
		{
			for (int k = 0; k < this.eventsContainer.transform.childCount; k++)
			{
				if (this.eventsContainer.transform.GetChild(k).name == "event")
				{
					MapEvent item2 = new MapEvent(this.eventsContainer.transform.GetChild(k).GetComponent<EditorEvent>().mapEvent);
					this.editedMapData.events.Add(item2);
				}
			}
			MapData mapData2 = this.editedMapData;
			IEnumerable<MapEvent> events3 = this.editedMapData.events;
			if (MapEditor.ADLAKIHINOM == null)
			{
				MapEditor.ADLAKIHINOM = new Func<MapEvent, float>(MapEditor.NMNLKCNHNIN);
			}
			mapData2.events = events3.OrderBy(MapEditor.ADLAKIHINOM).ToList<MapEvent>();
			this.editedMapData.e = string.Empty;
		}
		this.editedMapData.checkpoints.Clear();
		for (int l = 0; l < this.eventsContainer.transform.childCount; l++)
		{
			if (this.eventsContainer.transform.GetChild(l).name == "checkpoint")
			{
				this.editedMapData.checkpoints.Add(new MapEvent(this.eventsContainer.transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = this.editedMapData;
		IEnumerable<float> checkpoints = this.editedMapData.checkpoints;
		if (MapEditor.KCAPKHIJOHL == null)
		{
			MapEditor.KCAPKHIJOHL = new Func<float, float>(MapEditor.LPLFCLBJPEI);
		}
		mapData3.checkpoints = checkpoints.OrderBy(MapEditor.KCAPKHIJOHL).ToList<float>();
		return this.editedMapData;
	}

	// Token: 0x06010AD9 RID: 68313 RVA: 0x00575BFC File Offset: 0x00573DFC
	private void PLICILPAOJJ()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		using (List<string>.Enumerator enumerator = this.editedMapData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				MapEditor.CFBBHNAOKPA cfbbhnaokpa = new MapEditor.CFBBHNAOKPA();
				cfbbhnaokpa.IEOKJCPAOHL = enumerator.Current;
				cfbbhnaokpa.ADPIKBBAKHP = this;
				MapEditor.NDFEKONPOMG ndfekonpomg = new MapEditor.NDFEKONPOMG();
				ndfekonpomg.KHCIOAJAKOO = cfbbhnaokpa;
				ndfekonpomg.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				ndfekonpomg.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				ndfekonpomg.OBFJPHLBFOL.transform.localScale = new Vector3(1f, 1f, 1f);
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = cfbbhnaokpa.IEOKJCPAOHL;
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(ndfekonpomg.GBKBDKHPLKG));
				num++;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	// Token: 0x06010ADA RID: 68314 RVA: 0x000A6018 File Offset: 0x000A4218
	[CompilerGenerated]
	private static float MMAGIMBKFLF(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010ADB RID: 68315 RVA: 0x00575DC8 File Offset: 0x00573FC8
	private void NLJJIAIEIDH(float EHHBHEJBHNG, bool BNLKFNOIDHH = true)
	{
		if (this.IsMapLoaded())
		{
			float num;
			if (BNLKFNOIDHH)
			{
				num = EHHBHEJBHNG * this.audioSampler.audioSources[1].clip.length;
			}
			else
			{
				num = this.currentTime + EHHBHEJBHNG;
			}
			if (num < 0f)
			{
				num = 0f;
			}
			if (num >= this.audioSampler.audioSources[1].clip.length)
			{
				num = this.audioSampler.audioSources[1].clip.length;
			}
			this.currentTime = num;
			if (this.eventConfigCanvas.activeSelf)
			{
				this.FindNearestEvent(false);
			}
			if (this.isPlaying)
			{
				this.audioSampler.audioSources[1].time = this.currentTime;
			}
		}
	}

	// Token: 0x06010ADC RID: 68316 RVA: 0x00575EAC File Offset: 0x005740AC
	public void ReloadResList()
	{
		GameObject gameObject = this.resourcesScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (MapResource mapResource in this.editedMapData.levelResources)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.resourcesElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "resource";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ResourceListElement>().Init(mapResource.name, mapResource.path, Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).resources[mapResource.name]);
		}
	}

	// Token: 0x06010ADD RID: 68317 RVA: 0x00575FC4 File Offset: 0x005741C4
	public void UpdateBottomBar()
	{
		string text = string.Empty;
		if (!this.IsMapLoaded())
		{
			if (LocalizationService.Instance && LocalizationService.Instance.inited)
			{
				text = LocalizationService.Instance.GetLocalizatedText("#mapnotloaded");
			}
		}
		else
		{
			text = string.Concat(new object[]
			{
				this.CAFHKDIIDEE,
				"  |  ",
				Singleton<EditorHistoryHandler>.Instance.GetCurrentStateString(),
				"  |  Events Count: ",
				this.editedMapData.events.Count
			});
		}
		this.statusBarText.text = text;
		if (GameObject.Find("PlayButton"))
		{
			GameObject.Find("PlayButton").GetComponent<Image>().sprite = ((!this.audioSampler.audioSources[1].isPlaying) ? this.playImage : this.pauseImage);
		}
		if (GameObject.Find("RecordButton"))
		{
			Button component = GameObject.Find("RecordButton").GetComponent<Button>();
			ColorBlock colors = component.colors;
			colors.normalColor = (this.isRecording ? Color.red : Color.black);
			colors.highlightedColor = Helpers.HexToColor("#8E8E8EFF");
			colors.disabledColor = Color.black;
			colors.pressedColor = Helpers.HexToColor("#C8C8C8FF");
			component.colors = colors;
		}
	}

	// Token: 0x06010ADE RID: 68318 RVA: 0x00576140 File Offset: 0x00574340
	public void OnApplyCustomEventButton(List<string> NKEHMBLLEMH)
	{
		if (this.editingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = this.editingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(this.eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text, NumberStyles.Float, NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			this.editingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			this.editingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			this.editingEventGO.GetComponent<EditorEvent>().UpdatePositionFromData();
			this.eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text = string.Empty + this.editingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			this.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited event", false);
		}
	}

	// Token: 0x06010ADF RID: 68319 RVA: 0x0057623C File Offset: 0x0057443C
	private void CBEPLAGBOGD()
	{
		string nbebmkfpbep = Singleton<GameManager>.Instance.JJGKGCBCGGD(":");
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, false);
	}

	// Token: 0x06010AE0 RID: 68320 RVA: 0x00576268 File Offset: 0x00574468
	public void OnAddNewResourceButton()
	{
		string text = GameObject.Find("ResourceIDInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("ResourceFileSelector").GetComponent<FileSelector>().result;
		base.StartCoroutine(this.AddNewLevelResoure(text, result));
	}

	// Token: 0x06010AE1 RID: 68321 RVA: 0x000A63CC File Offset: 0x000A45CC
	public string GetMapID()
	{
		return this.CAFHKDIIDEE;
	}

	// Token: 0x06010AE2 RID: 68322 RVA: 0x00573C64 File Offset: 0x00571E64
	public IEnumerator BGPCGJNFHEO(bool BLIOAGPOANM = true, bool KIIAKJPJDKB = true)
	{
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		}
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData = this.GetEditedData(KIIAKJPJDKB);
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		Debug.Log("[MapEditor] Exported to " + fullLevelPath);
		Singleton<EditorHistoryHandler>.Instance.OnMapSaved();
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010AE3 RID: 68323 RVA: 0x00573C64 File Offset: 0x00571E64
	public IEnumerator BNCFFGABDLB(bool BLIOAGPOANM = true, bool KIIAKJPJDKB = true)
	{
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		}
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData = this.GetEditedData(KIIAKJPJDKB);
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		Debug.Log("[MapEditor] Exported to " + fullLevelPath);
		Singleton<EditorHistoryHandler>.Instance.OnMapSaved();
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010AE4 RID: 68324 RVA: 0x005762B0 File Offset: 0x005744B0
	public void ALMCMPBFBHN()
	{
		bool flag = this.eventConfigCanvas.activeSelf;
		base.StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(this.eventConfigCanvas, flag, null, true, 1515f, true));
		if (flag)
		{
			this.FindNearestEvent(true);
		}
		else
		{
			this.GPNKNBLBFOD.NNHKKFCEDAF();
			Singleton<UI>.Instance.ODEKNBPEHKH();
		}
	}

	// Token: 0x06010AE5 RID: 68325 RVA: 0x000A63D4 File Offset: 0x000A45D4
	private void LCJDCFFEMLP()
	{
		base.StartCoroutine(this.ConfirmExiting());
	}

	// Token: 0x06010AE6 RID: 68326 RVA: 0x00576314 File Offset: 0x00574514
	public void FGHJLGCPPFL()
	{
		this.audioSampler.audioSources[0].pitch += 417f;
		if (this.audioSampler.audioSources[0].pitch > 1593f)
		{
			this.audioSampler.audioSources[1].pitch = 444f;
		}
	}

	// Token: 0x06010AE7 RID: 68327 RVA: 0x00573C48 File Offset: 0x00571E48
	private IEnumerator BKEIMHKLJAN()
	{
		string text = GameObject.Find("MapFolderInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		string result2 = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		int acodlkjmcjf = (int)GameObject.Find("NewMapHandsCountSlider").GetComponent<Slider>().value;
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Helpers.ObtainAchievement(10);
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text2 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text2);
			Debug.Log("[MapEditor] Created new map: " + text2);
			yield return base.StartCoroutine(this.UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), result, result2, text2, true, acodlkjmcjf));
			this.IIIGPJIJHKD(text2);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010AE8 RID: 68328 RVA: 0x000A63E3 File Offset: 0x000A45E3
	public void SetBPMSplit(float DPNHODJHGJL)
	{
		this.BPMSplit = (int)DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010AE9 RID: 68329 RVA: 0x00576380 File Offset: 0x00574580
	private void HDMEKGJCKMG(string NBGPBKCPFDN)
	{
		this.IIIGPJIJHKD(NBGPBKCPFDN);
	}

	// Token: 0x06010AEA RID: 68330 RVA: 0x000A6018 File Offset: 0x000A4218
	[CompilerGenerated]
	private static float ABCOEBPCAJI(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010AEB RID: 68331 RVA: 0x000A6018 File Offset: 0x000A4218
	private static float JDHLODILCIA(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010AEC RID: 68332 RVA: 0x000A63F3 File Offset: 0x000A45F3
	public void OnSaveButton()
	{
		base.StartCoroutine(this.Save(true, true));
	}

	// Token: 0x06010AED RID: 68333 RVA: 0x00576398 File Offset: 0x00574598
	private IEnumerator GMKAIGKBLAA()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		if (MapEditor.PABLEKNHGMG.LNIJKGECNME == null)
		{
			MapEditor.PABLEKNHGMG.LNIJKGECNME = new Func<bool>(MapEditor.PABLEKNHGMG.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MapEditor.PABLEKNHGMG.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(0, -1, new List<int>
		{
			0,
			2,
			3,
			4
		}, false, null, null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			base.StartCoroutine(this.NODFLLCDCOH(Singleton<MapsListSelector>.Instance.result));
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		}
		yield break;
	}

	// Token: 0x06010AEE RID: 68334 RVA: 0x005763B4 File Offset: 0x005745B4
	private IEnumerator NLIGGKFCFNM()
	{
		TrashManRecycleBin khnadifnkfm = new TrashManRecycleBin
		{
			prefab = this.soundWaveGameObject,
			instancesToPreallocate = (int)this.audioSampler.audioSources[0].clip.length * 100
		};
		TrashMan.manageRecycleBin(khnadifnkfm, string.Empty);
		this.audioSampler.audioSources[0].Play();
		yield return new WaitWhile(new Func<bool>(base.GBKBDKHPLKG));
		Debug.Log("[LevelEditorScene] Print Audio Wave: Start");
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvas.soundwave.transform.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					Transform transform = (Transform)obj;
					TrashMan.despawn(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator2 as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		while (this.audioSampler.audioSources[0].isPlaying)
		{
			float num = this.audioSampler.GetFrequencyVol(0, FrequencyRange.Decibal) * 50f;
			foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
			{
				GameObject gameObject = TrashMan.spawn(this.soundWaveGameObject, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(eventsCanvas2.soundwave.transform, true);
				gameObject.transform.localScale = new Vector3(1f, num * 20f, 1f);
				gameObject.transform.localPosition = new Vector3(this.audioSampler.audioSources[0].time, 0f, 1f);
			}
			yield return new WaitForFixedUpdate();
		}
		Debug.Log("[LevelEditorScene] Print Audio Wave: Done");
		yield return true;
		yield break;
	}

	// Token: 0x06010AEF RID: 68335 RVA: 0x005763D0 File Offset: 0x005745D0
	public void DBHPKEFBMKP(string DPNHODJHGJL)
	{
		try
		{
			float bpm = float.Parse(DPNHODJHGJL, ~(NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint));
			this.SetBPM(bpm);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06010AF0 RID: 68336 RVA: 0x000A6018 File Offset: 0x000A4218
	[CompilerGenerated]
	private static float NMNLKCNHNIN(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010AF1 RID: 68337 RVA: 0x0057640C File Offset: 0x0057460C
	private void KPGJNNBMPOH()
	{
		this.currentBPMText.text = LocalizationService.Instance.EHOJEKMEKCB("Horizontal");
		this.currentBpmOffsetInputField.text = string.Empty + this.BPMOffset;
		this.currentBpmInputField.text = string.Empty + this.BPM;
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvas.bpmGrid.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					Transform transform = (Transform)obj;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator2 as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		if (this.useBPMSnap)
		{
			int num = 0;
			while ((float)num <= (float)Mathf.CeilToInt(this.editedMapData.musicTime) * (this.BPM * (float)this.BPMSplit / 1925f))
			{
				foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.bpmGridGameObject);
					gameObject.transform.SetParent(eventsCanvas2.bpmGrid);
					gameObject.transform.localPosition = new Vector3(this.BPMOffset + (float)num * (1339f / (this.BPM * (float)this.BPMSplit)), 1050f, 14f);
					gameObject.name = "_EmissionGain";
				}
				num += 0;
			}
		}
	}

	// Token: 0x06010AF2 RID: 68338 RVA: 0x000A6404 File Offset: 0x000A4604
	public void ILELMDLLHGF(string DPNHODJHGJL)
	{
		this.BPMOffset = float.Parse(DPNHODJHGJL);
		this.KPGJNNBMPOH();
	}

	// Token: 0x06010AF3 RID: 68339 RVA: 0x00576608 File Offset: 0x00574808
	public GameObject AddNewEvent(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null, bool KFDLOHFINOD = true)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "event";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		if (KFDLOHFINOD)
		{
			Singleton<EditorHistoryHandler>.Instance.SaveState("Added event", false);
			this.UpdateBottomBar();
			this.FindNearestEvent(true);
		}
		return gameObject;
	}

	// Token: 0x06010AF4 RID: 68340 RVA: 0x0057367C File Offset: 0x0057187C
	private IEnumerator DGOPBKEPGAN()
	{
		yield return new WaitForSeconds(0.5f);
		Singleton<UI>.Instance.SwitchView("StartCanvas", 0.2f);
		yield break;
	}

	// Token: 0x06010AF5 RID: 68341 RVA: 0x0057669C File Offset: 0x0057489C
	private IEnumerator AMAENBAABIN()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		if (MapEditor.ICAGHLKBFLC.LNIJKGECNME == null)
		{
			MapEditor.ICAGHLKBFLC.LNIJKGECNME = new Func<bool>(MapEditor.ICAGHLKBFLC.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MapEditor.ICAGHLKBFLC.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(1, 0, new List<int>
		{
			1
		}, false, null, null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			this.IIIGPJIJHKD(Singleton<MapsListSelector>.Instance.result);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		}
		yield break;
	}

	// Token: 0x06010AF6 RID: 68342 RVA: 0x0057669C File Offset: 0x0057489C
	private IEnumerator AJENEGMPAOD()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		if (MapEditor.ICAGHLKBFLC.LNIJKGECNME == null)
		{
			MapEditor.ICAGHLKBFLC.LNIJKGECNME = new Func<bool>(MapEditor.ICAGHLKBFLC.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MapEditor.ICAGHLKBFLC.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(1, 0, new List<int>
		{
			1
		}, false, null, null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			this.IIIGPJIJHKD(Singleton<MapsListSelector>.Instance.result);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		}
		yield break;
	}

	// Token: 0x06010AF7 RID: 68343 RVA: 0x000A6418 File Offset: 0x000A4618
	public void OnNewMapButton()
	{
		Singleton<UI>.Instance.SwitchView("MapCreationCanvas", 0.2f);
	}

	// Token: 0x06010AF8 RID: 68344 RVA: 0x00574AE8 File Offset: 0x00572CE8
	public IEnumerator EGFICEELHHG()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#exitmapeditor", "#yes", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			if (!this.IsMapLoaded())
			{
				Time.timeScale = 1f;
				ResourcesManager.UnloadResources(false);
				SceneManager.LoadScene("MenuScene");
			}
			else
			{
				if (Singleton<EditorHistoryHandler>.Instance.savedHistoryState != Singleton<EditorHistoryHandler>.Instance.state)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#savemapchanges?", "#yes", null, "#no", null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						yield return base.StartCoroutine(this.Save(true, true));
					}
				}
				Time.timeScale = 1f;
				ResourcesManager.UnloadResources(false);
				SceneManager.LoadScene("MenuScene");
			}
		}
		yield break;
	}

	// Token: 0x06010AF9 RID: 68345 RVA: 0x000A62B8 File Offset: 0x000A44B8
	private void NJLPCBFMKCM(string NBGPBKCPFDN)
	{
		this.Reset();
		this.CAFHKDIIDEE = NBGPBKCPFDN;
		base.StartCoroutine(this.GOGFAHNINFB());
	}

	// Token: 0x06010AFA RID: 68346 RVA: 0x005766B8 File Offset: 0x005748B8
	private GameObject KIDAPPHEPBE()
	{
		GameObject result = null;
		if (this.audioSampler.audioSources[1].clip != null)
		{
			float num = float.PositiveInfinity;
			for (int i = 0; i < this.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = this.eventsContainer.transform.GetChild(i).gameObject;
				if (gameObject.name != "checkpoint")
				{
					Vector3 position = gameObject.transform.position;
					float sqrMagnitude = (position - new Vector3(this.currentTime, (float)((this.currentEventsCanvasId != 0) ? 2 : -2), 0f)).sqrMagnitude;
					if (sqrMagnitude <= num && gameObject.GetComponent<EditorEvent>() && gameObject.GetComponent<EditorEvent>().mapEvent != null && gameObject.GetComponent<EditorEvent>().mapEvent.data != null)
					{
						result = gameObject;
						num = sqrMagnitude;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06010AFB RID: 68347 RVA: 0x000A642E File Offset: 0x000A462E
	public void MECJDMKHDJJ(float DPNHODJHGJL)
	{
		this.BPMOffset = DPNHODJHGJL;
		this.KPGJNNBMPOH();
	}

	// Token: 0x06010AFC RID: 68348 RVA: 0x005767C4 File Offset: 0x005749C4
	public void OnMapStatsButton()
	{
		MapData editedData = this.GetEditedData(true);
		int mapMaxScore = Helpers.GetMapMaxScore(editedData);
		float mapDifficulty = Helpers.GetMapDifficulty(editedData);
		if (editedData.configVersion >= 3 && !string.IsNullOrEmpty(editedData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(editedData.e, Singleton<SaveSystem>.Instance.folder));
				editedData.events.AddRange(editedData.events);
			}
			catch (Exception)
			{
			}
		}
		float num = editedData.speed;
		float num2 = editedData.speed;
		IEnumerable<MapEvent> events = editedData.events;
		if (MapEditor.LNIJKGECNME == null)
		{
			MapEditor.LNIJKGECNME = new Func<MapEvent, bool>(MapEditor.IFMCPCOBNNH);
		}
		List<MapEvent> list = events.Where(MapEditor.LNIJKGECNME).ToList<MapEvent>();
		if (list.Count > 0)
		{
			foreach (MapEvent mapEvent in list)
			{
				float num3 = float.Parse(mapEvent.data[1], CultureInfo.InvariantCulture);
				if (num > num3)
				{
					num = num3;
				}
				if (num2 < num3)
				{
					num2 = num3;
				}
			}
		}
		string format = "{0,-18} {1,18}";
		string text = "<b><i>Map's Stats:</i></b>" + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		text = text + string.Format(format, "<b>Difficulty</b>:", mapDifficulty.ToString("0.00")) + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		text = text + string.Format(format, "<b>Max Score</b>:", mapMaxScore) + Environment.NewLine;
		text = text + string.Format(format, "<b>Time</b>:", editedData.musicTime.ToString("0.00")) + Environment.NewLine;
		text = text + string.Format(format, "<b>HP</b>:", editedData.lives + "/" + editedData.maxLives) + Environment.NewLine;
		text = text + string.Format(format, "<b>Speed</b>:", num.ToString("0") + "-" + num2.ToString("0")) + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(text, "#ok", null, true, false, 0f);
	}

	// Token: 0x06010AFD RID: 68349 RVA: 0x000A62B8 File Offset: 0x000A44B8
	private void ICHFAPLFOLD(string NBGPBKCPFDN)
	{
		this.Reset();
		this.CAFHKDIIDEE = NBGPBKCPFDN;
		base.StartCoroutine(this.GOGFAHNINFB());
	}

	// Token: 0x06010AFE RID: 68350 RVA: 0x00576A5C File Offset: 0x00574C5C
	private void MMGJGLLFKML()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		using (List<string>.Enumerator enumerator = this.editedMapData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				MapEditor.CFBBHNAOKPA cfbbhnaokpa = new MapEditor.CFBBHNAOKPA();
				cfbbhnaokpa.IEOKJCPAOHL = enumerator.Current;
				cfbbhnaokpa.ADPIKBBAKHP = this;
				MapEditor.NDFEKONPOMG ndfekonpomg = new MapEditor.NDFEKONPOMG();
				ndfekonpomg.KHCIOAJAKOO = cfbbhnaokpa;
				ndfekonpomg.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				ndfekonpomg.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				ndfekonpomg.OBFJPHLBFOL.transform.localScale = new Vector3(42f, 564f, 520f);
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = cfbbhnaokpa.IEOKJCPAOHL;
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(ndfekonpomg.BKNHHGBPLGH));
				num++;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(1615f, 1889f, 571f);
	}

	// Token: 0x06010AFF RID: 68351 RVA: 0x00576C28 File Offset: 0x00574E28
	public void SwichCanvas()
	{
		this.currentEventsCanvasId++;
		if (this.currentEventsCanvasId >= this.eventsCanvases.Count)
		{
			this.currentEventsCanvasId = 0;
		}
		if (this.eventConfigCanvas.activeSelf)
		{
			this.FindNearestEvent(false);
		}
	}

	// Token: 0x06010B00 RID: 68352 RVA: 0x000A616A File Offset: 0x000A436A
	public void OnExitButton()
	{
		this.LCJDCFFEMLP();
	}

	// Token: 0x06010B01 RID: 68353 RVA: 0x00576C78 File Offset: 0x00574E78
	public void OnDeleteButton()
	{
		if (Singleton<EditorArcsSelector>.Instance.selectedunits.Count > 0)
		{
			foreach (GameObject obj in Singleton<EditorArcsSelector>.Instance.selectedunits)
			{
				UnityEngine.Object.Destroy(obj);
			}
			Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
			Singleton<EditorHistoryHandler>.Instance.SaveState("Delete events", false);
		}
	}

	// Token: 0x06010B02 RID: 68354 RVA: 0x00576D0C File Offset: 0x00574F0C
	private void BLLONNLMMNA()
	{
		string nbebmkfpbep = Singleton<GameManager>.Instance.CreateServerURL("uploads/Intralism/mods_terms.pdf");
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, true);
	}

	// Token: 0x06010B03 RID: 68355 RVA: 0x000A616A File Offset: 0x000A436A
	public void AIHEDPOLDJO()
	{
		this.LCJDCFFEMLP();
	}

	// Token: 0x06010B04 RID: 68356 RVA: 0x00576D38 File Offset: 0x00574F38
	private void BMDDFOKBIAK(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null, true, false, 0f);
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultOK)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null, true, false, 0f);
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		else
		{
			Singleton<GameManager>.Instance.OpenURL("https://steamcommunity.com/sharedfiles/filedetails/?id=" + NPIKJHPJIEA.m_nPublishedFileId, true);
			Debug.Log("[LevelEditorScene] Map submitted!");
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null, true, false, 0f);
			if (RanksSystem.IsOfficial(NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, false))
			{
				string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
				string ddaomdpaiep = fullLevelPath + "/" + Helpers.levelConfigFileName;
				int mapMaxScore = Helpers.GetMapMaxScore(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
				float mapDifficulty = Helpers.GetMapDifficulty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
				base.StartCoroutine(Singleton<RanksSystem>.Instance.UpdateOfficialMap(string.Empty + NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, Helpers.CalculateMD5(ddaomdpaiep), mapDifficulty, mapMaxScore));
			}
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		this.PAODIJKEBCA = false;
	}

	// Token: 0x06010B05 RID: 68357 RVA: 0x00576EB0 File Offset: 0x005750B0
	private void PFIPOJIIODP(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("[LevelEditorScene] Error: I/O Failure! :(");
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultInsufficientPrivilege)
		{
			if (eResult != EResult.k_EResultTimeout)
			{
				if (eResult == EResult.k_EResultNotLoggedOn)
				{
					Debug.Log("[LevelEditorScene] Error: You're not logged into Steam!");
				}
			}
			else
			{
				Debug.Log("[LevelEditorScene] Error: Timeout :S");
			}
		}
		else
		{
			Debug.Log("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(");
		}
		if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
		{
			Debug.Log("[MapEditor] Item creation successful! Published Item ID: " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
			base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.workshopConfigFileName, NPIKJHPJIEA.m_nPublishedFileId.ToString(), true));
			base.StartCoroutine(this.KGCHKEGFNHI(NPIKJHPJIEA.m_nPublishedFileId, "Created"));
		}
	}

	// Token: 0x06010B06 RID: 68358 RVA: 0x0009C240 File Offset: 0x0009A440
	[CompilerGenerated]
	private static float LPLFCLBJPEI(float HPHENPOHOMK)
	{
		return HPHENPOHOMK;
	}

	// Token: 0x06010B07 RID: 68359 RVA: 0x000A643D File Offset: 0x000A463D
	public void OnMapResourcesButton()
	{
		this.currentState = MapEditor.EditorState.Busy;
		Singleton<UI>.Instance.SwitchView("ResourcesConfig", 0.2f);
	}

	// Token: 0x06010B08 RID: 68360 RVA: 0x000A645A File Offset: 0x000A465A
	public void SetBPMOffsetText(string DPNHODJHGJL)
	{
		this.BPMOffset = float.Parse(DPNHODJHGJL);
		this.DPGILDLHMLM();
	}

	// Token: 0x06010B09 RID: 68361 RVA: 0x00576FD8 File Offset: 0x005751D8
	public void CJFGHCLBEAO()
	{
		this.audioSampler.audioSources[0].pitch -= 37f;
		if (this.audioSampler.audioSources[1].pitch < 1873f)
		{
			this.audioSampler.audioSources[1].pitch = 1782f;
		}
	}

	// Token: 0x06010B0A RID: 68362 RVA: 0x000A646E File Offset: 0x000A466E
	public void SetBPMOffsetToCaret()
	{
		this.BPMOffset = this.currentTime;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010B0B RID: 68363 RVA: 0x000A6482 File Offset: 0x000A4682
	public MapData GetEditedMapDataObj()
	{
		return this.editedMapData;
	}

	// Token: 0x06010B0C RID: 68364 RVA: 0x000A648A File Offset: 0x000A468A
	public void OnImportMapButton()
	{
		base.StartCoroutine(this.GMKAIGKBLAA());
	}

	// Token: 0x06010B0D RID: 68365 RVA: 0x00572904 File Offset: 0x00570B04
	public IEnumerator LCDEAPPGBOA()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#updateoutdatedmap", "#yes", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().value = (float)MapData.GetLastConfigVersion();
			yield return base.StartCoroutine(this.Save(true, true));
			this.IIIGPJIJHKD(this.CAFHKDIIDEE);
		}
		Singleton<SaveSystem>.Instance.SetBool("maps." + this.CAFHKDIIDEE + ".sawoutdatedmessage", true, null);
		yield break;
	}

	// Token: 0x06010B0E RID: 68366 RVA: 0x00577044 File Offset: 0x00575244
	public void SetEditedData(MapData NOJGGCLPPAM)
	{
		Singleton<EditorArcsSelector>.Instance.ClearSelection();
		this.editedMapData = new MapData(NOJGGCLPPAM);
		this.configCanvas.transform.Find("Tab1Content").Find("LevelNameInputField").GetComponent<InputField>().text = this.editedMapData.name;
		this.configCanvas.transform.Find("Tab1Content").Find("LevelInfoInputField").GetComponent<InputField>().text = this.editedMapData.info;
		this.configCanvas.transform.Find("Tab1Content").Find("LevelURLInputField").GetComponent<InputField>().text = this.editedMapData.moreInfoURL;
		this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().minValue = 1f;
		this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().maxValue = (float)MapData.GetLastConfigVersion();
		this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().value = (float)this.editedMapData.configVersion;
		this.configCanvas.transform.Find("Tab2Content").Find("SpeedSlider").GetComponent<Slider>().value = (float)((int)this.editedMapData.speed);
		this.configCanvas.transform.Find("Tab2Content").Find("LivesSlider").GetComponent<Slider>().value = (float)this.editedMapData.lives;
		this.configCanvas.transform.Find("Tab2Content").Find("MaxLivesSlider").GetComponent<Slider>().value = (float)this.editedMapData.maxLives;
		this.configCanvas.transform.Find("Tab2Content").Find("HandsCountSlider").GetComponent<Slider>().value = (float)this.editedMapData.handCount;
		this.configCanvas.transform.Find("Tab2Content").Find("EnvironmentSlider").GetComponent<Slider>().value = (float)this.editedMapData.environmentType;
		this.configCanvas.transform.Find("Tab2Content").Find("HiddenToggle").GetComponent<Toggle>().isOn = this.editedMapData.hidden;
		GameObject gameObject = this.tagsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string text in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.tagElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "tagElement";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<Toggle>().isOn = this.editedMapData.tags.Contains(text);
			gameObject2.GetComponentInChildren<Text>().text = text;
		}
		if (Helpers.specialTags.Count > 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.tagHeaderElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "tagElement";
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.GetComponentInChildren<Text>().text = " ";
		}
		foreach (string text2 in Helpers.tags)
		{
			GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.tagElement);
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.name = "tagElement";
			gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject4.GetComponent<Toggle>().isOn = this.editedMapData.tags.Contains(text2);
			gameObject4.GetComponentInChildren<Text>().text = text2;
		}
		this.PLICILPAOJJ();
		this.ReloadResList();
		if (this.editedMapData.configVersion >= 3 && !string.IsNullOrEmpty(this.editedMapData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(this.editedMapData.e, Singleton<SaveSystem>.Instance.folder));
				this.editedMapData.events.AddRange(edata.events);
			}
			catch (Exception)
			{
			}
		}
		IEnumerator enumerator3 = this.eventsContainer.transform.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				object obj = enumerator3.Current;
				Transform transform = (Transform)obj;
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator3 as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		foreach (MapEvent mapEvent in this.editedMapData.events)
		{
			GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
			gameObject5.transform.SetParent(this.eventsContainer.transform);
			gameObject5.GetComponent<EditorEvent>().mapEvent = mapEvent;
			gameObject5.GetComponent<EditorEvent>().UpdateEvent();
			gameObject5.name = "event";
		}
		foreach (float num in this.editedMapData.checkpoints)
		{
			float ehhbhejbhng = num;
			GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
			gameObject6.transform.SetParent(this.eventsContainer.transform);
			gameObject6.GetComponent<EditorEvent>().mapEvent = new MapEvent(ehhbhejbhng, new List<string>
			{
				"checkpoint"
			});
			gameObject6.GetComponent<EditorEvent>().UpdateEvent();
			gameObject6.name = "checkpoint";
		}
		this.GPNKNBLBFOD.StopEditing();
		this.UpdateBottomBar();
		this.FindNearestEvent(true);
	}

	// Token: 0x06010B0F RID: 68367 RVA: 0x00572904 File Offset: 0x00570B04
	public IEnumerator ShowOutdatedMapWarning()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#updateoutdatedmap", "#yes", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().value = (float)MapData.GetLastConfigVersion();
			yield return base.StartCoroutine(this.Save(true, true));
			this.IIIGPJIJHKD(this.CAFHKDIIDEE);
		}
		Singleton<SaveSystem>.Instance.SetBool("maps." + this.CAFHKDIIDEE + ".sawoutdatedmessage", true, null);
		yield break;
	}

	// Token: 0x06010B10 RID: 68368 RVA: 0x00577734 File Offset: 0x00575934
	public void HBDKEOFBGHE()
	{
		bool flag = this.eventConfigCanvas.activeSelf;
		base.StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(this.eventConfigCanvas, flag, null, false, 1456f, true));
		if (flag)
		{
			this.FindNearestEvent(true);
		}
		else
		{
			this.GPNKNBLBFOD.OMLACFOPMAG();
			Singleton<UI>.Instance.IOOEOHAHDAG();
		}
	}

	// Token: 0x06010B11 RID: 68369 RVA: 0x000A6499 File Offset: 0x000A4699
	public void BKHCMAMHKMH()
	{
		this.currentState = (MapEditor.EditorState)4;
		Singleton<UI>.Instance.LNDLDKAPMAE("settings.volume.editor", 1339f);
	}

	// Token: 0x06010B12 RID: 68370 RVA: 0x00577798 File Offset: 0x00575998
	public void MJOHFNIJBGC()
	{
		string text = GameObject.Find("SetEnvSpriteColor").GetComponent<InputField>().text;
		string result = GameObject.Find("settings.enablerankingnotifications").GetComponent<FileSelector>().result;
		base.StartCoroutine(this.AddNewLevelResoure(text, result));
	}

	// Token: 0x06010B13 RID: 68371 RVA: 0x005777E0 File Offset: 0x005759E0
	private IEnumerator ONJIIJDEFOM()
	{
		if (Singleton<EditorHistoryHandler>.Instance.savedHistoryState != Singleton<EditorHistoryHandler>.Instance.state)
		{
			yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#savemapbeforeuploading", "#yes", null, "#no", null));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return base.StartCoroutine(this.Save(true, true));
			}
		}
		if (Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)) + ".completed", 0, null) == 1 || !string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
		{
			if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#creatingnewitem", string.Empty, null, false, false, 0f);
				SteamAPICall_t hAPICall = SteamUGC.CreateItem((AppId_t)513510U, EWorkshopFileType.k_EWorkshopFileTypeFirst);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				Debug.Log("[MapsEditor] Creating new item...");
			}
			else
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#mapalreadyexistupdate", "#yes", null, "#no", null));
				if (Singleton<MessageBoxPanel>.Instance.result == 1)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog("#changenote", "#submit", null, null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						base.StartCoroutine(this.KGCHKEGFNHI(new PublishedFileId_t(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId)), Singleton<MessageBoxPanel>.Instance.textResult));
					}
				}
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#mapmustbecompletebeforesubmit", "OK", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010B14 RID: 68372 RVA: 0x00573C64 File Offset: 0x00571E64
	public IEnumerator MECBCHDHOHE(bool BLIOAGPOANM = true, bool KIIAKJPJDKB = true)
	{
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		}
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData = this.GetEditedData(KIIAKJPJDKB);
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		Debug.Log("[MapEditor] Exported to " + fullLevelPath);
		Singleton<EditorHistoryHandler>.Instance.OnMapSaved();
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010B15 RID: 68373 RVA: 0x005777FC File Offset: 0x005759FC
	public void Update()
	{
		if (!this.PAODIJKEBCA && Input.GetKeyDown(KeyCode.Escape))
		{
			this.OnExitButton();
		}
		if (this.PAODIJKEBCA)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(this.FHKGDJDOKNB, out num, out num2);
			float iadppjhimbg = num / num2;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null, true, false, 0f);
				this.PAODIJKEBCA = false;
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Preparing configuration", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Preparing content", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Uploading content", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Uploading preview image", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Committing changes...", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			}
		}
		if (!this.IsMapLoaded())
		{
			this.currentTimeText.text = "0.00/0.00";
		}
		else
		{
			this.currentTimeText.text = this.currentTime.ToString("0.00") + "/" + this.audioSampler.audioSources[1].clip.length.ToString("0.00");
			this.currentTimeSlider.value = this.currentTime;
			if (this.isPlaying)
			{
				if (this.audioSampler.audioSources[1].isPlaying)
				{
					this.currentTime = this.audioSampler.audioSources[1].time;
					if (this.eventConfigCanvas.activeSelf)
					{
						this.FindNearestEvent(false);
					}
				}
				else
				{
					this.isPlaying = false;
					this.UpdateBottomBar();
				}
			}
			this.EHEAELMGGIH();
		}
	}

	// Token: 0x06010B16 RID: 68374 RVA: 0x00577A18 File Offset: 0x00575C18
	private IEnumerator KGCHKEGFNHI(PublishedFileId_t JMMILEFMACB, string GIGBCMLIKKE)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		string haebghhmebh = fullLevelPath + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(haebghhmebh, true));
		UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate((AppId_t)513510U, JMMILEFMACB);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE);
		SteamUGC.SetItemTitle(ugcupdateHandle_t, mapData.mapData.name);
		SteamUGC.SetItemDescription(ugcupdateHandle_t, mapData.mapData.info);
		SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
		SteamUGC.SetItemContent(ugcupdateHandle_t, fullLevelPath);
		SteamUGC.SetItemPreview(ugcupdateHandle_t, fullLevelPath + "/" + mapData.mapData.iconFile);
		List<string> tags = mapData.mapData.tags;
		SteamUGC.SetItemTags(ugcupdateHandle_t, tags);
		this.PAODIJKEBCA = true;
		SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, GIGBCMLIKKE);
		this.FHKGDJDOKNB = ugcupdateHandle_t;
		this.KAPDFIOHNGL.Set(hAPICall, null);
		yield break;
	}

	// Token: 0x06010B17 RID: 68375 RVA: 0x00577A44 File Offset: 0x00575C44
	public float GetSnappedBPM(float GEMDHBEGEFH)
	{
		if (this.useBPMSnap)
		{
			bool flag = true;
			float result = 0f;
			float num = 0f;
			int num2 = 0;
			while ((float)num2 <= (float)Mathf.CeilToInt(this.editedMapData.musicTime) * (this.BPM * (float)this.BPMSplit / 60f))
			{
				float num3 = this.BPMOffset + (float)num2 * (60f / (this.BPM * (float)this.BPMSplit));
				if (flag)
				{
					result = num3;
					num = Mathf.Abs(GEMDHBEGEFH - num3);
					flag = false;
				}
				if (Mathf.Abs(GEMDHBEGEFH - num3) < num)
				{
					result = num3;
					num = Mathf.Abs(GEMDHBEGEFH - num3);
				}
				num2++;
			}
			return result;
		}
		return GEMDHBEGEFH;
	}

	// Token: 0x04001D4F RID: 7503
	public Text currentBPMText;

	// Token: 0x04001D50 RID: 7504
	public InputField currentBpmInputField;

	// Token: 0x04001D51 RID: 7505
	public InputField currentBpmOffsetInputField;

	// Token: 0x04001D52 RID: 7506
	public Toggle useBpmToggle;

	// Token: 0x04001D53 RID: 7507
	public float BPM = 120f;

	// Token: 0x04001D54 RID: 7508
	public bool useBPMSnap = true;

	// Token: 0x04001D55 RID: 7509
	public float BPMOffset;

	// Token: 0x04001D56 RID: 7510
	public int BPMSplit = 4;

	// Token: 0x04001D57 RID: 7511
	[Header("System")]
	public AudioSampler audioSampler;

	// Token: 0x04001D58 RID: 7512
	public MapEditor.EditorState currentState;

	// Token: 0x04001D59 RID: 7513
	public GameObject eventsContainer;

	// Token: 0x04001D5A RID: 7514
	public List<MapEditor.EventsCanvas> eventsCanvases;

	// Token: 0x04001D5B RID: 7515
	[Header("UI")]
	public GameObject volumePanel;

	// Token: 0x04001D5C RID: 7516
	public GameObject topMenuPanel;

	// Token: 0x04001D5D RID: 7517
	public Text statusBarText;

	// Token: 0x04001D5E RID: 7518
	public Text currentTimeText;

	// Token: 0x04001D5F RID: 7519
	public Slider currentTimeSlider;

	// Token: 0x04001D60 RID: 7520
	public Slider zoomSlider;

	// Token: 0x04001D61 RID: 7521
	public GameObject configCanvas;

	// Token: 0x04001D62 RID: 7522
	public GameObject tagsScrollRectContent;

	// Token: 0x04001D63 RID: 7523
	public GameObject unlockConditionContent;

	// Token: 0x04001D64 RID: 7524
	public GameObject resourcesScrollRectContent;

	// Token: 0x04001D65 RID: 7525
	public GameObject eventConfigCanvas;

	// Token: 0x04001D66 RID: 7526
	[Header("References")]
	public Sprite playImage;

	// Token: 0x04001D67 RID: 7527
	public Sprite pauseImage;

	// Token: 0x04001D68 RID: 7528
	public GameObject eventGameObject;

	// Token: 0x04001D69 RID: 7529
	public GameObject gridGameObject;

	// Token: 0x04001D6A RID: 7530
	public GameObject bpmGridGameObject;

	// Token: 0x04001D6B RID: 7531
	public GameObject caretGameObject;

	// Token: 0x04001D6C RID: 7532
	public GameObject soundWaveGameObject;

	// Token: 0x04001D6D RID: 7533
	public GameObject tagElement;

	// Token: 0x04001D6E RID: 7534
	public GameObject tagHeaderElement;

	// Token: 0x04001D6F RID: 7535
	public GameObject unlockConditionElement;

	// Token: 0x04001D70 RID: 7536
	public GameObject addNewUnlockConditionElement;

	// Token: 0x04001D71 RID: 7537
	public GameObject resourcesElement;

	// Token: 0x04001D72 RID: 7538
	[HideInInspector]
	public float currentTime;

	// Token: 0x04001D73 RID: 7539
	[HideInInspector]
	public int currentEventsCanvasId;

	// Token: 0x04001D74 RID: 7540
	[HideInInspector]
	public bool isPlaying;

	// Token: 0x04001D75 RID: 7541
	[HideInInspector]
	public bool isRecording;

	// Token: 0x04001D76 RID: 7542
	[HideInInspector]
	public GameObject editingEventGO;

	// Token: 0x04001D77 RID: 7543
	private string CAFHKDIIDEE;

	// Token: 0x04001D78 RID: 7544
	[SerializeField]
	private MapData editedMapData;

	// Token: 0x04001D79 RID: 7545
	private bool DMOOGKMALBD;

	// Token: 0x04001D7A RID: 7546
	private GameObject AEAKHCLJFDH;

	// Token: 0x04001D7B RID: 7547
	private CustomEventEditor GPNKNBLBFOD;

	// Token: 0x04001D7C RID: 7548
	private bool PAODIJKEBCA;

	// Token: 0x04001D7D RID: 7549
	private UGCUpdateHandle_t FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;

	// Token: 0x04001D7E RID: 7550
	protected CallResult<CreateItemResult_t> CEJIPNKDJKJ;

	// Token: 0x04001D7F RID: 7551
	protected CallResult<SubmitItemUpdateResult_t> KAPDFIOHNGL;

	// Token: 0x04001D80 RID: 7552
	[CompilerGenerated]
	private static Func<MapEvent, bool> LNIJKGECNME;

	// Token: 0x04001D81 RID: 7553
	[CompilerGenerated]
	private static Func<MapEvent, float> CLCBJCKCBDD;

	// Token: 0x04001D82 RID: 7554
	[CompilerGenerated]
	private static Func<MapEvent, float> HCLEECLNOEA;

	// Token: 0x04001D83 RID: 7555
	[CompilerGenerated]
	private static Func<MapEvent, float> ADLAKIHINOM;

	// Token: 0x04001D84 RID: 7556
	[CompilerGenerated]
	private static Func<float, float> KCAPKHIJOHL;

	// Token: 0x02000490 RID: 1168
	public enum EditorState
	{
		// Token: 0x04001D86 RID: 7558
		Init,
		// Token: 0x04001D87 RID: 7559
		MapLoaded,
		// Token: 0x04001D88 RID: 7560
		Busy
	}

	// Token: 0x02000491 RID: 1169
	public enum EventType
	{
		// Token: 0x04001D8A RID: 7562
		Gameplay,
		// Token: 0x04001D8B RID: 7563
		Storyboard
	}

	// Token: 0x02000492 RID: 1170
	[Serializable]
	public class EventsCanvas
	{
		// Token: 0x06010B18 RID: 68376 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public EventsCanvas()
		{
		}

		// Token: 0x04001D8C RID: 7564
		public MapEditor.EventType forType;

		// Token: 0x04001D8D RID: 7565
		public Transform grid;

		// Token: 0x04001D8E RID: 7566
		public Transform bpmGrid;

		// Token: 0x04001D8F RID: 7567
		public Transform soundwave;
	}

	// Token: 0x0200049B RID: 1179
	[CompilerGenerated]
	private sealed class CFBBHNAOKPA
	{
		// Token: 0x06010E48 RID: 69192 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public CFBBHNAOKPA()
		{
		}

		// Token: 0x04001DBC RID: 7612
		internal string IEOKJCPAOHL;

		// Token: 0x04001DBD RID: 7613
		internal MapEditor ADPIKBBAKHP;
	}

	// Token: 0x0200049C RID: 1180
	[CompilerGenerated]
	private sealed class NDFEKONPOMG
	{
		// Token: 0x06010E49 RID: 69193 RVA: 0x00588198 File Offset: 0x00586398
		internal void OFHCGKJFGDI()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EBOBKIOLMLD("MainThreadExecuter", false);
		}

		// Token: 0x06010E4A RID: 69194 RVA: 0x005881E8 File Offset: 0x005863E8
		internal void PBCAHKDLFPE()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.ICNMFKDPDBM("set", true);
		}

		// Token: 0x06010E4B RID: 69195 RVA: 0x00588238 File Offset: 0x00586438
		internal void AEINPAGJFME()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("Editor", false);
		}

		// Token: 0x06010E4C RID: 69196 RVA: 0x00588288 File Offset: 0x00586488
		internal void FFEGPHJKMFK()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_MainTex2", true);
		}

		// Token: 0x06010E4D RID: 69197 RVA: 0x005882D8 File Offset: 0x005864D8
		internal void BKNHHGBPLGH()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("sounds/hit_perfect", false);
		}

		// Token: 0x06010E4E RID: 69198 RVA: 0x00588328 File Offset: 0x00586528
		internal void BFEABMIFIEE()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.LCDEMMDAANK("_Value4", true);
		}

		// Token: 0x06010E4F RID: 69199 RVA: 0x00588378 File Offset: 0x00586578
		internal void BDGDIDPDBHG()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("_Value2", true);
		}

		// Token: 0x06010E50 RID: 69200 RVA: 0x005883C8 File Offset: 0x005865C8
		internal void EFAPFFFGOOA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("VHS", false);
		}

		// Token: 0x06010E51 RID: 69201 RVA: 0x00588418 File Offset: 0x00586618
		internal void PIJAOCFAPKC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("PossibleMapMaxScoreText", false);
		}

		// Token: 0x06010E52 RID: 69202 RVA: 0x00588468 File Offset: 0x00586668
		internal void JBCHBMKPDAJ()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.BGGABKAGPAN("CameraFilterPack/3D_Scan_Scene", false);
		}

		// Token: 0x06010E53 RID: 69203 RVA: 0x005884B8 File Offset: 0x005866B8
		internal void JKEDCEOCPJO()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("_Gain", true);
		}

		// Token: 0x06010E54 RID: 69204 RVA: 0x00588508 File Offset: 0x00586708
		internal void OLIGLEMPFOP()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("_Value", false);
		}

		// Token: 0x06010E55 RID: 69205 RVA: 0x00588558 File Offset: 0x00586758
		internal void LHHFJBIAHCN()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("Tab2Content", false);
		}

		// Token: 0x06010E56 RID: 69206 RVA: 0x005885A8 File Offset: 0x005867A8
		internal void FMIHBNPKEEO()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("Uploading content", true);
		}

		// Token: 0x06010E57 RID: 69207 RVA: 0x005885F8 File Offset: 0x005867F8
		internal void DKGPCPBNDPK()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KAINPLCCDKL("MultiplayerButton", true);
		}

		// Token: 0x06010E58 RID: 69208 RVA: 0x00588648 File Offset: 0x00586848
		internal void JBAJEMGOPDL()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("[ERROR KEY {0}]", true);
		}

		// Token: 0x06010E59 RID: 69209 RVA: 0x00588698 File Offset: 0x00586898
		internal void OFLDIMDDLHM()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("EnvironmentSlider", true);
		}

		// Token: 0x06010E5A RID: 69210 RVA: 0x005886E8 File Offset: 0x005868E8
		internal void KGKMOLCPDIH()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.DOGOJGAKDNF("#mapalreadyexistupdate", false);
		}

		// Token: 0x06010E5B RID: 69211 RVA: 0x00588738 File Offset: 0x00586938
		internal void BMAOCLKPNNC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("CameraFilterPack/TV_LED", true);
		}

		// Token: 0x06010E5C RID: 69212 RVA: 0x00588788 File Offset: 0x00586988
		internal void DNIMHEKGJHB()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO("_Value2", true);
		}

		// Token: 0x06010E5D RID: 69213 RVA: 0x005887D8 File Offset: 0x005869D8
		internal void HBJFIOJFBHC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.LCDEMMDAANK("CameraFilterPack/Glasses_On", false);
		}

		// Token: 0x06010E5E RID: 69214 RVA: 0x00588828 File Offset: 0x00586A28
		internal void DBFPGFHEGKA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KMIIHCELMAG("settings.volume.menu", false);
		}

		// Token: 0x06010E5F RID: 69215 RVA: 0x00588878 File Offset: 0x00586A78
		internal void BJMAIJDIKCN()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("[PlayerBase] New highscore", true);
		}

		// Token: 0x06010E60 RID: 69216 RVA: 0x005888C8 File Offset: 0x00586AC8
		internal void KFNBKFELFLH()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM("HiddenToggle", true);
		}

		// Token: 0x06010E61 RID: 69217 RVA: 0x00588918 File Offset: 0x00586B18
		internal void AEIFJLBBKBP()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("_Value3", true);
		}

		// Token: 0x06010E62 RID: 69218 RVA: 0x00588968 File Offset: 0x00586B68
		internal void FHIJCPPECHA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("_TimeX", false);
		}

		// Token: 0x06010E63 RID: 69219 RVA: 0x005889B8 File Offset: 0x00586BB8
		internal void INHOEMCLAAP()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.ICNMFKDPDBM("You need to have a child LayoutGroup content set for the list: ", false);
		}

		// Token: 0x06010E64 RID: 69220 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public NDFEKONPOMG()
		{
		}

		// Token: 0x06010E65 RID: 69221 RVA: 0x00588A08 File Offset: 0x00586C08
		internal void PKAPLCFHDOC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("sfxVolume", false);
		}

		// Token: 0x06010E66 RID: 69222 RVA: 0x00588A58 File Offset: 0x00586C58
		internal void LNDGINDKPFA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("_FresnelFade", true);
		}

		// Token: 0x06010E67 RID: 69223 RVA: 0x00588AA8 File Offset: 0x00586CA8
		internal void IGFOBPKFCDJ()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("_Value6", false);
		}

		// Token: 0x06010E68 RID: 69224 RVA: 0x00588AF8 File Offset: 0x00586CF8
		internal void FDAIFOAGDLA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.LCDEMMDAANK("X", true);
		}

		// Token: 0x06010E69 RID: 69225 RVA: 0x00588B48 File Offset: 0x00586D48
		internal void FCAGEDLBBHD()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.LCDEMMDAANK("[PlayerBase] Delete checkpoint data", false);
		}

		// Token: 0x06010E6A RID: 69226 RVA: 0x00588B98 File Offset: 0x00586D98
		internal void LOEAMHGMMPK()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("stretchWidth", false);
		}

		// Token: 0x06010E6B RID: 69227 RVA: 0x00588BE8 File Offset: 0x00586DE8
		internal void AGJKEBOPIOC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("_Value2", true);
		}

		// Token: 0x06010E6C RID: 69228 RVA: 0x00588C38 File Offset: 0x00586E38
		internal void FJDBPPKABJE()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.DOGOJGAKDNF("plogs", true);
		}

		// Token: 0x06010E6D RID: 69229 RVA: 0x00588C88 File Offset: 0x00586E88
		internal void EGKGJJGAPMN()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("[PlayerController] ", false);
		}

		// Token: 0x06010E6E RID: 69230 RVA: 0x00588CD8 File Offset: 0x00586ED8
		internal void LLNDDFGPOPL()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("CheckCombo", true);
		}

		// Token: 0x06010E6F RID: 69231 RVA: 0x00588D28 File Offset: 0x00586F28
		internal void GBKBDKHPLKG()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions", false);
		}

		// Token: 0x06010E70 RID: 69232 RVA: 0x00588D78 File Offset: 0x00586F78
		internal void LJDLIIIPIIJ()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HKNIGKOOPJH("Case-Sensitive", false);
		}

		// Token: 0x06010E71 RID: 69233 RVA: 0x00588DC8 File Offset: 0x00586FC8
		internal void MEMPOPNAEDN()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.FLPFLJAEDKL("_Value", false);
		}

		// Token: 0x06010E72 RID: 69234 RVA: 0x00588E18 File Offset: 0x00587018
		internal void FIPCLHEKKCA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.LCDEMMDAANK("AVG Misses:", false);
		}

		// Token: 0x06010E73 RID: 69235 RVA: 0x00588E68 File Offset: 0x00587068
		internal void JDELIMPGFDJ()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.LCDEMMDAANK("_Screen", false);
		}

		// Token: 0x06010E74 RID: 69236 RVA: 0x00588EB8 File Offset: 0x005870B8
		internal void FHFECFLBHMA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.AAIMDGLFENM(".completedCount", true);
		}

		// Token: 0x06010E75 RID: 69237 RVA: 0x00588F08 File Offset: 0x00587108
		internal void MGENGAEDACG()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GEIAJHOHMHG("SpawnObj", false);
		}

		// Token: 0x06010E76 RID: 69238 RVA: 0x00588F58 File Offset: 0x00587158
		internal void BEBAENEJFLD()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.IOCLDCLCNNB("_TimeX", true);
		}

		// Token: 0x06010E77 RID: 69239 RVA: 0x00588FA8 File Offset: 0x005871A8
		internal void EKHOOPGPPGE()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAJOKMCPBMO(".workshop.json", true);
		}

		// Token: 0x04001DBE RID: 7614
		internal GameObject OBFJPHLBFOL;

		// Token: 0x04001DBF RID: 7615
		internal MapEditor.CFBBHNAOKPA KHCIOAJAKOO;
	}
}
