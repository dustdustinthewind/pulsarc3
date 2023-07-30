// ShowInfoOfPlayer
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class ShowInfoOfPlayer : Photon.MonoBehaviour
{
	private GameObject GFLFBLOLIGA;

	private TextMesh GFNILPAPGJN;

	public float CharacterSize;

	public Font font;

	public bool DisableOnOwnObjects;

	private void GHILDCBCDJI()
	{
		bool flag = !DisableOnOwnObjects || ACPGHFHDCIP().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = IJBFILBDGDO().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.DBMPNLFFBEB() : ("_ScreenResolution" + owner.ID));
			}
			else if (IJBFILBDGDO().isSceneView)
			{
				GFNILPAPGJN.text = "_VignetteColor";
			}
			else
			{
				GFNILPAPGJN.text = "Waiting for AvailableRegions. State: ";
			}
		}
	}

	private void GPFJMKCGHGB()
	{
		bool flag = DisableOnOwnObjects && GMAHNPNHMFK().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = BLMHOKPIMOD().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.DBMPNLFFBEB())) ? photonPlayer.DBMPNLFFBEB() : ("PunPickup" + photonPlayer.FHEAKIMCKJC()));
			}
			else if (EDIJKHEMPAD().isSceneView)
			{
				GFNILPAPGJN.text = "JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
			}
			else
			{
				GFNILPAPGJN.text = "#craftng";
			}
		}
	}

	private void KMKLDAJLCNM()
	{
		bool flag = !DisableOnOwnObjects || BLMHOKPIMOD().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = GMAHNPNHMFK().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.OLPCOKMLDFD())) ? photonPlayer.OLPCOKMLDFD() : ("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account." + photonPlayer.ID));
			}
			else if (AAMNKPHHHCI().isSceneView)
			{
				GFNILPAPGJN.text = "_Value2";
			}
			else
			{
				GFNILPAPGJN.text = "_History3Weight";
			}
		}
	}

	private void JILOMOBDPIA()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning("Set Arcs Speed" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("_Value");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.UpperRight;
			if (CharacterSize > 914f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void IMCKJCHKMKB()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[0];
			Debug.LogWarning("BitsData" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("3d text");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.UpperLeft;
			if (CharacterSize > 1761f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void Update()
	{
		bool flag = !DisableOnOwnObjects || base.photonView.isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = base.photonView.owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("player" + owner.ID));
			}
			else if (base.photonView.isSceneView)
			{
				GFNILPAPGJN.text = "scn";
			}
			else
			{
				GFNILPAPGJN.text = "n/a";
			}
		}
	}

	private void IDIIELPAMCJ()
	{
		bool flag = !DisableOnOwnObjects || BBGIDKNEGHD().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = EDIJKHEMPAD().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.DBMPNLFFBEB() : ("_Skybox" + owner.ID));
			}
			else if (JAEJDHHCJJO().isSceneView)
			{
				GFNILPAPGJN.text = " methods \"";
			}
			else
			{
				GFNILPAPGJN.text = "MultiplayerButton";
			}
		}
	}

	private void CFIAKIJAILI()
	{
		bool flag = !DisableOnOwnObjects || EDIJKHEMPAD().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = AAMNKPHHHCI().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.OLPCOKMLDFD() : ("maps." + photonPlayer.FHEAKIMCKJC()));
			}
			else if (GMAHNPNHMFK().isSceneView)
			{
				GFNILPAPGJN.text = "JITTER";
			}
			else
			{
				GFNILPAPGJN.text = "Error: Can not set the OnSerialize rate higher than the overall SendRate.";
			}
		}
	}

	private void OCMKCBBCEFG()
	{
		bool flag = !DisableOnOwnObjects || JAEJDHHCJJO().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = JDBCGCJJIAF().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.OLPCOKMLDFD())) ? photonPlayer.OLPCOKMLDFD() : ("HitVariationSlider" + photonPlayer.FHEAKIMCKJC()));
			}
			else if (BBGIDKNEGHD().isSceneView)
			{
				GFNILPAPGJN.text = "CameraFilterPack/FX_Drunk2";
			}
			else
			{
				GFNILPAPGJN.text = "_Offsets";
			}
		}
	}

	private void ONMGIPAILOH()
	{
		bool flag = !DisableOnOwnObjects || IJBFILBDGDO().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = JDBCGCJJIAF().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("#ok" + owner.FHEAKIMCKJC()));
			}
			else if (IJBFILBDGDO().isSceneView)
			{
				GFNILPAPGJN.text = "_Value";
			}
			else
			{
				GFNILPAPGJN.text = "_Offsets";
			}
		}
	}

	private void KMCPMOGKDEH()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[0];
			Debug.LogWarning("LevelEditor/patterns" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject(".completedCount");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.MiddleLeft;
			if (CharacterSize > 1808f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void MAOCOEGAFND()
	{
		bool flag = !DisableOnOwnObjects || BLMHOKPIMOD().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = IJBFILBDGDO().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.DBMPNLFFBEB())) ? photonPlayer.NickName : ("0 - background, 1 - foreground" + photonPlayer.ID));
			}
			else if (CIACEFBNDDJ().isSceneView)
			{
				GFNILPAPGJN.text = "_TimeX";
			}
			else
			{
				GFNILPAPGJN.text = "_DiffuseColor";
			}
		}
	}

	private void MMBPLGGLPDB()
	{
		bool flag = DisableOnOwnObjects && FFIPLLNKGEN().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = OELHGNKAMEG().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.OLPCOKMLDFD() : ("ResourceIDInputField" + photonPlayer.FHEAKIMCKJC()));
			}
			else if (IJBFILBDGDO().isSceneView)
			{
				GFNILPAPGJN.text = "CameraFilterPack/Blend2Camera_Blend";
			}
			else
			{
				GFNILPAPGJN.text = "_Value2";
			}
		}
	}

	private void BGDPIHMAACO()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[0];
			Debug.LogWarning("Error: you cannot read this stream that you are writing!" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("type");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.MiddleCenter;
			if (CharacterSize > 369f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void CIPKEPDELJB()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[0];
			Debug.LogWarning("Aug" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("LobbyCanvas");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.MiddleRight;
			if (CharacterSize > 929f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void JKFDDNMPOJH()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning(".lastCheckpoint.perfectHits" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("menu.enableselectormusic");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.LowerRight;
			if (CharacterSize > 1752f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void LCJHDLKJEOM()
	{
		bool flag = !DisableOnOwnObjects || AAMNKPHHHCI().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = EDIJKHEMPAD().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.DBMPNLFFBEB() : ("_TimeX" + photonPlayer.ID));
			}
			else if (OELHGNKAMEG().isSceneView)
			{
				GFNILPAPGJN.text = "CameraFilterPack_Paper1";
			}
			else
			{
				GFNILPAPGJN.text = "_TimeX";
			}
		}
	}

	private void BGFJOEPFOPM()
	{
		bool flag = DisableOnOwnObjects && JDBCGCJJIAF().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = OELHGNKAMEG().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.OLPCOKMLDFD())) ? photonPlayer.NickName : ("_Amount" + photonPlayer.ID));
			}
			else if (GBHNDHLAJLI().isSceneView)
			{
				GFNILPAPGJN.text = "_Value4";
			}
			else
			{
				GFNILPAPGJN.text = "workshop.";
			}
		}
	}

	private void FABMDEHEDNO()
	{
		bool flag = !DisableOnOwnObjects || GMAHNPNHMFK().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = EOOCGIFFKBG().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.DBMPNLFFBEB())) ? owner.OLPCOKMLDFD() : ("/Segment-[Down]" + owner.ID));
			}
			else if (OELHGNKAMEG().isSceneView)
			{
				GFNILPAPGJN.text = "[Right]";
			}
			else
			{
				GFNILPAPGJN.text = "0.00";
			}
		}
	}

	private void JHPOIOELNCG()
	{
		bool flag = DisableOnOwnObjects && IBKCMBIGOEJ().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = EOOCGIFFKBG().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.OLPCOKMLDFD())) ? owner.DBMPNLFFBEB() : ("_Value3" + owner.FHEAKIMCKJC()));
			}
			else if (JDBCGCJJIAF().isSceneView)
			{
				GFNILPAPGJN.text = "note.2";
			}
			else
			{
				GFNILPAPGJN.text = "mapselector.filter.favoriteonly";
			}
		}
	}

	private void JAAJECBCCFM()
	{
		bool flag = DisableOnOwnObjects && BLMHOKPIMOD().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = JDBCGCJJIAF().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.DBMPNLFFBEB())) ? photonPlayer.DBMPNLFFBEB() : ("0x" + photonPlayer.ID));
			}
			else if (JIOCGDBKGIL().isSceneView)
			{
				GFNILPAPGJN.text = "CameraFilterPack_Atmosphere_Rain_FX";
			}
			else
			{
				GFNILPAPGJN.text = "CameraFilterPack/Blend2Camera_ColorBurn";
			}
		}
	}

	private void KIMMMCJFMAB()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning("accuracy" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("menu.playedpage");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.UpperLeft;
			if (CharacterSize > 299f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void AIJGAJIOJDJ()
	{
		bool flag = !DisableOnOwnObjects || JIOCGDBKGIL().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = JAEJDHHCJJO().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.DBMPNLFFBEB() : ("_Value2" + photonPlayer.FHEAKIMCKJC()));
			}
			else if (AAMNKPHHHCI().isSceneView)
			{
				GFNILPAPGJN.text = "_TimeX";
			}
			else
			{
				GFNILPAPGJN.text = "/";
			}
		}
	}

	private void Start()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[0];
			Debug.LogWarning("No font defined. Found font: " + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("3d text");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.MiddleCenter;
			if (CharacterSize > 0f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void NKLIHNJCHOG()
	{
		bool flag = !DisableOnOwnObjects || PHCBHAFMDEJ().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = JIOCGDBKGIL().GLFNAPCBIJP();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("Keypad" + photonPlayer.ID));
			}
			else if (FFIPLLNKGEN().isSceneView)
			{
				GFNILPAPGJN.text = "_TimeX";
			}
			else
			{
				GFNILPAPGJN.text = "_Distortion";
			}
		}
	}

	private void FEHCNJLLJMP()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning("_OcclusionBlurTexture" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("inventory.selected.");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.UpperCenter;
			if (CharacterSize > 832f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void LEAHIBJDMBI()
	{
		bool flag = DisableOnOwnObjects && JAEJDHHCJJO().isMine;
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = EDIJKHEMPAD().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.OLPCOKMLDFD())) ? owner.OLPCOKMLDFD() : ("Data/Maps/" + owner.ID));
			}
			else if (JIOCGDBKGIL().isSceneView)
			{
				GFNILPAPGJN.text = "CameraFilterPack/Blend2Camera_Luminosity";
			}
			else
			{
				GFNILPAPGJN.text = "TimeBGSlider";
			}
		}
	}

	private void NPLCENPNJBM()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[0];
			Debug.LogWarning("ZoomSpeed" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("Alpha");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.MiddleCenter;
			if (CharacterSize > 1971f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void BEBNOKFLJPH()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning("menu.selectedplaymode" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("Saved as: ");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.MiddleCenter;
			if (CharacterSize > 853f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}
}
