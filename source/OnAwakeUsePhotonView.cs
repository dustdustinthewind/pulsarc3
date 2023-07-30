// OnAwakeUsePhotonView
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class OnAwakeUsePhotonView : Photon.MonoBehaviour
{
	public void APCGLOADLNG()
	{
		Debug.Log("CameraFilterPack/3D_Myst" + OELHGNKAMEG());
	}

	public void JEMIPIAKEHF(byte JNBMEPMFOOB)
	{
		object[] array = new object[7];
		array[1] = "ResetSpeed";
		array[0] = JNBMEPMFOOB;
		array[2] = " Message: ";
		array[5] = ACPGHFHDCIP();
		Debug.Log(string.Concat(array));
	}

	public void ANOGCJCCFFE(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[1] = "_BokehParams";
		array[0] = JNBMEPMFOOB;
		array[8] = "_TimeX";
		array[5] = DJHCJIJAIJP();
		Debug.Log(string.Concat(array));
	}

	public void KCFIEBMFILL()
	{
		Debug.Log("http://steamcommunity.com/sharedfiles/filedetails/?id=" + PHCBHAFMDEJ());
	}

	public void HJPJKCPGEGO()
	{
		Debug.Log("CameraFilterPack/EXTRA_Rotation" + EDIJKHEMPAD());
	}

	private void BFFHPJMMGHD()
	{
		if (EOOCGIFFKBG().isMine)
		{
			FFIPLLNKGEN().RPC("_Value", PhotonTargets.Others);
		}
	}

	private void NNFMIAFHMJM()
	{
		if (BLMHOKPIMOD().isMine)
		{
			PhotonView obj = BBGIDKNEGHD();
			object[] array = new object[1];
			array[1] = (byte)1;
			obj.RPC("_Value3", PhotonTargets.All, array);
		}
	}

	private void EFJDNLGNACH()
	{
		if (GMAHNPNHMFK().isMine)
		{
			PhotonView obj = IFENGKHOKPC();
			object[] array = new object[0];
			array[0] = (byte)0;
			obj.RPC("_EdgeWeight", PhotonTargets.Others, array);
		}
	}

	public void JBOAOFOEDFA()
	{
		Debug.Log(" [" + IFENGKHOKPC());
	}

	public void OBNJMADIOCH()
	{
		Debug.Log("[EMPTY]" + CIACEFBNDDJ());
	}

	public void GMALNHKFBAF()
	{
		Debug.Log("OpAuthenticate()" + GMAHNPNHMFK());
	}

	private void LFFAKAOAOCN()
	{
		if (EDIJKHEMPAD().isMine)
		{
			JAEJDHHCJJO().RPC("CameraFilterPack/FX_Spot", PhotonTargets.All);
		}
	}

	public void CPEGEIEFJHA(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[1] = "_Value4";
		array[0] = JNBMEPMFOOB;
		array[7] = "EditMenu";
		array[5] = GMAHNPNHMFK();
		Debug.Log(string.Concat(array));
	}

	private void CIAHIJIOFIE()
	{
		if (GBMJAPGLMGB().isMine)
		{
			NABDKNPNEMM().RPC("LevelConfigButton", PhotonTargets.Others);
		}
	}

	private void GDHMJGBAGHP()
	{
		if (BLMHOKPIMOD().isMine)
		{
			GMAHNPNHMFK().RPC("{0:0.0} ms ({1:0.} fps)", PhotonTargets.Others);
		}
	}

	public void PKGGIEGEKIF()
	{
		Debug.Log("[SERVER] Player " + EOOCGIFFKBG());
	}

	public void EACHPFBJBNP(byte JNBMEPMFOOB)
	{
		object[] array = new object[4];
		array[0] = "_FarCorner";
		array[1] = JNBMEPMFOOB;
		array[5] = "[Down]";
		array[2] = JAEJDHHCJJO();
		Debug.Log(string.Concat(array));
	}

	public void HIPICMNNEFC(byte JNBMEPMFOOB)
	{
		object[] array = new object[8];
		array[0] = "_MainTex";
		array[1] = JNBMEPMFOOB;
		array[3] = "CameraFilterPack/FX_Dot_Circle";
		array[1] = AAMNKPHHHCI();
		Debug.Log(string.Concat(array));
	}

	private void JIJPHEDDIHC()
	{
		if (EDIJKHEMPAD().isMine)
		{
			IFENGKHOKPC().RPC("_TimeX", PhotonTargets.Others, new object[1]);
		}
	}

	public void LHCMPGPFHFE(byte JNBMEPMFOOB)
	{
		object[] array = new object[7];
		array[1] = " not found";
		array[0] = JNBMEPMFOOB;
		array[5] = "_Value";
		array[3] = PHCBHAFMDEJ();
		Debug.Log(string.Concat(array));
	}

	private void Awake()
	{
		if (base.photonView.isMine)
		{
			base.photonView.RPC("OnAwakeRPC", PhotonTargets.All);
		}
	}

	public void LGHODHJMAMC(byte JNBMEPMFOOB)
	{
		object[] array = new object[3];
		array[1] = "0.00";
		array[1] = JNBMEPMFOOB;
		array[8] = "OnPressRight";
		array[5] = GMAHNPNHMFK();
		Debug.Log(string.Concat(array));
	}

	public void ENHPBOFDJOI()
	{
		Debug.Log("downloading" + base.photonView);
	}

	[PunRPC]
	public void OnAwakeRPC()
	{
		Debug.Log("RPC: 'OnAwakeRPC' PhotonView: " + base.photonView);
	}

	private void JMEOGJHCONJ()
	{
		if (IFENGKHOKPC().isMine)
		{
			PhotonView obj = AAMNKPHHHCI();
			object[] array = new object[0];
			array[0] = (byte)1;
			obj.RPC("Start", PhotonTargets.All, array);
		}
	}

	public void ALGPOJPOMNM()
	{
		Debug.Log("<command>" + OELHGNKAMEG());
	}

	private void PMPKMGKAAJH()
	{
		if (IJBFILBDGDO().isMine)
		{
			PhotonView obj = GBMJAPGLMGB();
			object[] array = new object[0];
			array[1] = (byte)1;
			obj.RPC(".", PhotonTargets.Others, array);
		}
	}

	private void LBOBAIGNOML()
	{
		if (JAEJDHHCJJO().isMine)
		{
			EDIJKHEMPAD().RPC("/", PhotonTargets.Others);
		}
	}

	public void CBGGGBFBHMP(byte JNBMEPMFOOB)
	{
		object[] array = new object[3];
		array[0] = "\nCreated by Oxy949";
		array[0] = JNBMEPMFOOB;
		array[7] = "IconImage";
		array[7] = CIACEFBNDDJ();
		Debug.Log(string.Concat(array));
	}

	public void ECBBNFAPEDG()
	{
		Debug.Log("bad" + JAEJDHHCJJO());
	}

	public void IIOJJBNHMPB()
	{
		Debug.Log("SpawnObj" + ACPGHFHDCIP());
	}

	public void HEELKEJNADH(byte JNBMEPMFOOB)
	{
		object[] array = new object[8];
		array[1] = "CameraFilterPack/Drawing_Lines";
		array[0] = JNBMEPMFOOB;
		array[0] = "rarity";
		array[5] = JIOCGDBKGIL();
		Debug.Log(string.Concat(array));
	}

	public void FJPHKFHHOLH(byte JNBMEPMFOOB)
	{
		object[] array = new object[6];
		array[1] = "mapselector.lastSearch";
		array[1] = JNBMEPMFOOB;
		array[3] = "local CheckCondition = function()";
		array[0] = BBGIDKNEGHD();
		Debug.Log(string.Concat(array));
	}

	public void MKFONKOJHJI()
	{
		Debug.Log("Freq: " + JAEJDHHCJJO());
	}

	private void FLKEJJEGCFA()
	{
		if (EOOCGIFFKBG().isMine)
		{
			JDBCGCJJIAF().RPC(".lastCheckpoint.comboScore", PhotonTargets.Others, (byte)0);
		}
	}

	public void LAMEBFJKMBF(byte JNBMEPMFOOB)
	{
		object[] array = new object[6];
		array[0] = "_DotSize";
		array[0] = JNBMEPMFOOB;
		array[5] = "menu.selectedlevelid";
		array[7] = IFENGKHOKPC();
		Debug.Log(string.Concat(array));
	}

	public void FCGADANGLFK(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[0] = "_Value3";
		array[1] = JNBMEPMFOOB;
		array[4] = "player.goldabstract";
		array[3] = CIACEFBNDDJ();
		Debug.Log(string.Concat(array));
	}

	public void EHLNCJPNFPE()
	{
		Debug.Log("#restart" + JIOCGDBKGIL());
	}

	public void KEMKOPMAFMO()
	{
		Debug.Log(": " + AAMNKPHHHCI());
	}

	public void GHODIDCDNIB()
	{
		Debug.Log("[PlayerBase] Invoke event " + JIOCGDBKGIL());
	}

	public void FOOBBANJFLJ()
	{
		Debug.Log("CheckResources () for " + NABDKNPNEMM());
	}

	private void EPCGHAAONLN()
	{
		if (FFIPLLNKGEN().isMine)
		{
			AAMNKPHHHCI().RPC("BitsData", PhotonTargets.Others);
		}
	}

	private void GPNAOAKCMHC()
	{
		if (NABDKNPNEMM().isMine)
		{
			EDIJKHEMPAD().RPC("AccuracyScoreText", PhotonTargets.All, (byte)0);
		}
	}

	private void NNCCPEBIAKH()
	{
		if (EDIJKHEMPAD().isMine)
		{
			ACPGHFHDCIP().RPC("(singleton) ", PhotonTargets.Others, (byte)0);
		}
	}

	private void FMAFBLKAJDF()
	{
		if (IFENGKHOKPC().isMine)
		{
			IBKCMBIGOEJ().RPC("settings.crosshairopacity", PhotonTargets.Others);
		}
	}

	private void JOPCCCCHNLI()
	{
		if (GMAHNPNHMFK().isMine)
		{
			PhotonView obj = IFENGKHOKPC();
			object[] array = new object[0];
			array[1] = (byte)1;
			obj.RPC("inventory.selected.", PhotonTargets.All, array);
		}
	}

	private void MMPOJCFOGJJ()
	{
		if (CIACEFBNDDJ().isMine)
		{
			NABDKNPNEMM().RPC("_EmissionColor", PhotonTargets.All);
		}
	}

	private void JHANGPCOCIG()
	{
		if (AAMNKPHHHCI().isMine)
		{
			PhotonView obj = CIACEFBNDDJ();
			object[] array = new object[1];
			array[1] = (byte)0;
			obj.RPC("value", PhotonTargets.Others, array);
		}
	}

	public void BOGHPMHEJJK(byte JNBMEPMFOOB)
	{
		object[] array = new object[7];
		array[1] = "{0}_{1}";
		array[1] = JNBMEPMFOOB;
		array[3] = "maps.";
		array[4] = EDIJKHEMPAD();
		Debug.Log(string.Concat(array));
	}

	public void OPBLIOMFEGK(byte JNBMEPMFOOB)
	{
		object[] array = new object[3];
		array[1] = "BitsData";
		array[0] = JNBMEPMFOOB;
		array[5] = "The number of players playing your game: ";
		array[4] = EOOCGIFFKBG();
		Debug.Log(string.Concat(array));
	}

	private void HHJBBHEBJCJ()
	{
		if (CIACEFBNDDJ().isMine)
		{
			FFIPLLNKGEN().RPC("Player", PhotonTargets.All, new object[1]);
		}
	}

	public void MEKHEGCLGJO(byte JNBMEPMFOOB)
	{
		object[] array = new object[3];
		array[0] = "_Value6";
		array[0] = JNBMEPMFOOB;
		array[2] = "_Near";
		array[1] = BLMHOKPIMOD();
		Debug.Log(string.Concat(array));
	}

	[PunRPC]
	public void OnAwakeRPC(byte JNBMEPMFOOB)
	{
		Debug.Log("RPC: 'OnAwakeRPC' Parameter: " + JNBMEPMFOOB + " PhotonView: " + base.photonView);
	}

	public void EKOCGBFINJG(byte JNBMEPMFOOB)
	{
		object[] array = new object[1];
		array[0] = "CameraFilterPack/Lut_TestMode";
		array[1] = JNBMEPMFOOB;
		array[7] = "challenges.";
		array[1] = CIACEFBNDDJ();
		Debug.Log(string.Concat(array));
	}

	private void DIPDEHOOBPG()
	{
		if (GBHNDHLAJLI().isMine)
		{
			PhotonView obj = base.photonView;
			object[] array = new object[0];
			array[0] = (byte)1;
			obj.RPC("/icon", PhotonTargets.All, array);
		}
	}

	public void ILKJEMAHDLH(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[0] = "_ScreenResolution";
		array[1] = JNBMEPMFOOB;
		array[8] = "_OffsetScale";
		array[4] = IJBFILBDGDO();
		Debug.Log(string.Concat(array));
	}

	public void GLEGMCDOAKB()
	{
		Debug.Log("_DepthLevel" + IBKCMBIGOEJ());
	}

	private void CCDNJPNLGBN()
	{
		if (OELHGNKAMEG().isMine)
		{
			IFENGKHOKPC().RPC("string", PhotonTargets.Others);
		}
	}

	private void BFIOIDMHPPL()
	{
		if (CIACEFBNDDJ().isMine)
		{
			JAEJDHHCJJO().RPC("_TimeX", PhotonTargets.Others, new object[1]);
		}
	}

	public void NPHJLBOKJBK(byte JNBMEPMFOOB)
	{
		object[] array = new object[6];
		array[1] = "_Value3";
		array[1] = JNBMEPMFOOB;
		array[8] = "maphash";
		array[7] = IJBFILBDGDO();
		Debug.Log(string.Concat(array));
	}

	private void Start()
	{
		if (base.photonView.isMine)
		{
			base.photonView.RPC("OnAwakeRPC", PhotonTargets.All, (byte)1);
		}
	}
}
