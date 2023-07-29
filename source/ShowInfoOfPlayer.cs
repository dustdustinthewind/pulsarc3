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

	private void BGFJOEPFOPM()
	{
		bool flag = DisableOnOwnObjects && AAMNKPHHHCI().BGJKMGJBPFA();
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = JAEJDHHCJJO().JJFEGIOPFGN();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("_DotSize" + photonPlayer.ID));
			}
			else if (GBHNDHLAJLI().FJEMLGIGOCJ())
			{
				GFNILPAPGJN.text = "Parent object ID. Case-Sensitive";
			}
			else
			{
				GFNILPAPGJN.text = ":";
			}
		}
	}

	private void JAAJECBCCFM()
	{
		bool flag = DisableOnOwnObjects && OELHGNKAMEG().DOLKFPIABDD();
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = GMAHNPNHMFK().JFCKAGHNNCA();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("Warning: No Shape Curve set for CurveWaveform.cs on " + photonPlayer.ID));
			}
			else if (base.photonView.FJEMLGIGOCJ())
			{
				GFNILPAPGJN.text = "SetEnvSpriteColor";
			}
			else
			{
				GFNILPAPGJN.text = "D-Pad Down";
			}
		}
	}

	private void CFIAKIJAILI()
	{
		bool flag = !DisableOnOwnObjects || EOOCGIFFKBG().BGJKMGJBPFA();
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = base.photonView.owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("_Params1" + owner.ID));
			}
			else if (GMAHNPNHMFK().isSceneView)
			{
				GFNILPAPGJN.text = "win";
			}
			else
			{
				GFNILPAPGJN.text = "_Far";
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

	private void MFMIODIAKNI()
	{
		bool flag = DisableOnOwnObjects && FFIPLLNKGEN().BGJKMGJBPFA();
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = GBHNDHLAJLI().JFCKAGHNNCA();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("/" + photonPlayer.ID));
			}
			else if (GBMJAPGLMGB().NADJFHDOFGD())
			{
				GFNILPAPGJN.text = ".sawoutdatedmessage";
			}
			else
			{
				GFNILPAPGJN.text = "_Value2";
			}
		}
	}

	private void OCMKCBBCEFG()
	{
		bool flag = DisableOnOwnObjects && GMAHNPNHMFK().BGJKMGJBPFA();
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer photonPlayer = GMAHNPNHMFK().JJFEGIOPFGN();
			if (photonPlayer != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("[LocalizationService] All languages: " + photonPlayer.ID));
			}
			else if (base.photonView.LIDEPDFOMFC())
			{
				GFNILPAPGJN.text = "[Up]";
			}
			else
			{
				GFNILPAPGJN.text = "_ScreenResolution";
			}
		}
	}

	private void NBGIMIDICKE()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning("Load scene by name or build id" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("[PlayerController] ");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.UpperRight;
			if (CharacterSize > 923f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}

	private void LEAHIBJDMBI()
	{
		bool flag = DisableOnOwnObjects && IBKCMBIGOEJ().BGJKMGJBPFA();
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = AAMNKPHHHCI().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("DPADHOR" + owner.ONIKFABKELO()));
			}
			else if (ACPGHFHDCIP().LIDEPDFOMFC())
			{
				GFNILPAPGJN.text = "Object ID. Case-Sensitive";
			}
			else
			{
				GFNILPAPGJN.text = "[MapsData] Found ";
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

	private void JHPOIOELNCG()
	{
		bool flag = DisableOnOwnObjects && OELHGNKAMEG().BGJKMGJBPFA();
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = BLMHOKPIMOD().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("_ScreenResolution" + owner.ONIKFABKELO()));
			}
			else if (GMAHNPNHMFK().FJEMLGIGOCJ())
			{
				GFNILPAPGJN.text = "_Distortion";
			}
			else
			{
				GFNILPAPGJN.text = "checkpoint";
			}
		}
	}

	private void AAPKBNDHBLI()
	{
		bool flag = !DisableOnOwnObjects || BLMHOKPIMOD().BGJKMGJBPFA();
		if (GFLFBLOLIGA != null)
		{
			GFLFBLOLIGA.SetActive(flag);
		}
		if (flag)
		{
			PhotonPlayer owner = GMAHNPNHMFK().owner;
			if (owner != null)
			{
				GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("_Value2" + owner.ONIKFABKELO()));
			}
			else if (AAMNKPHHHCI().NADJFHDOFGD())
			{
				GFNILPAPGJN.text = "ItemsCountText";
			}
			else
			{
				GFNILPAPGJN.text = "_TimeX";
			}
		}
	}

	private void CCLNNLCOPBL()
	{
		if (font == null)
		{
			font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning("SetCrosshairColor" + font);
		}
		if (GFNILPAPGJN == null)
		{
			GFLFBLOLIGA = new GameObject("_Near");
			GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = font.material;
			GFNILPAPGJN = GFLFBLOLIGA.AddComponent<TextMesh>();
			GFNILPAPGJN.font = font;
			GFNILPAPGJN.anchor = TextAnchor.MiddleCenter;
			if (CharacterSize > 358f)
			{
				GFNILPAPGJN.characterSize = CharacterSize;
			}
		}
	}
}
