// SpriteController
using UnityEngine;
using UnityEngine.UI;

public class SpriteController : EnvironmentController
{
	public Color color = new Color(1f, 1f, 1f);

	public float colorLerp = 10f;

	[SerializeField]
	private Image rend;

	public override void AIJGAJIOJDJ()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void BALOPNDKKFJ()
	{
	}

	public void APBAABJJDKH(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void NHJBGDIEGPH()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1770f, 460f, 1971f, 137f);
		color = new Color(901f, 1036f, 1423f);
		colorLerp = 1435f;
	}

	public void MOIEADAAPPJ(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void MJNMHMIEDMP(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void LDDKCCMHMIC()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void CNFGAKBCDJG()
	{
	}

	public void KEOBKNFGDHE()
	{
	}

	public override void EEDLLCHIAKG()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1234f, 706f, 1697f, 1848f);
		color = new Color(499f, 873f, 822f);
		colorLerp = 926f;
	}

	public override void LLDHEJIEDHO()
	{
		base.LEAHIBJDMBI();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void Awake()
	{
		base.Awake();
	}

	public override void EJFJENFKLND()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void OMAEOBBHHCP()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1402f, 373f, 1912f, 1562f);
		color = new Color(740f, 561f, 860f);
		colorLerp = 180f;
	}

	public override void EPFFFDFBFMA()
	{
		base.FMAFBLKAJDF();
	}

	public override void IIBOPBADDGH()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(724f, 1600f, 380f, 270f);
		color = new Color(218f, 1723f, 1092f);
		colorLerp = 1007f;
	}

	public override void CKCPHFLOLAH()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(353f, 257f, 1098f, 1333f);
		color = new Color(1f, 1791f, 1131f);
		colorLerp = 974f;
	}

	public void CKCIOJNHFLD()
	{
	}

	public override void ANKIJGCGCBF()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void EAFIBAIHCCM(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 767f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void PGODLFEBOCJ(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void IOMCHHBGJEC()
	{
		base.FMAFBLKAJDF();
	}

	public override void JAAJECBCCFM()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void EIDFHPLLDAP(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void BNGGJMNMBBL()
	{
		base.Awake();
	}

	public void EKJFDPCNLFG()
	{
	}

	public override void OFKDKJGIDLH()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1614f, 736f, 819f, 100f);
		color = new Color(221f, 500f, 1336f);
		colorLerp = 489f;
	}

	public override void FHPPMBEEKBL()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1969f, 437f, 1708f, 1180f);
		color = new Color(1132f, 768f, 1764f);
		colorLerp = 1819f;
	}

	public override void CIAHIJIOFIE()
	{
		base.Awake();
	}

	public override void MADENBGHKDD()
	{
		base.BODPLDJLFCF();
	}

	public void OAFMNEJDOLH(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void CMNFFNPJDJN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 32f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void HMKBLLMIKAB()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void BABMEBHPHDA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 79f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void JEKEBJCHOHO()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(104f, 1872f, 512f, 894f);
		color = new Color(1620f, 827f, 418f);
		colorLerp = 1265f;
	}

	public override void LFCFPJOIMOE()
	{
		base.BODPLDJLFCF();
	}

	public void JHNIODIFDMN(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void GENIGIKJGCG()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1810f, 1660f, 1293f, 418f);
		color = new Color(1425f, 144f, 1208f);
		colorLerp = 715f;
	}

	public void IADAIEHLDNG()
	{
	}

	public override void IPJENEAMGBP()
	{
		base.FMAFBLKAJDF();
	}

	public void DKKBNDBKKFA(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void APKNAPHOFHC()
	{
		base.BGFJOEPFOPM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void LNGDHCGGJFK(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void DKCAFMLKNAL()
	{
	}

	public void GOOOLPOGNAN()
	{
	}

	public void PMIHCPDBNCK()
	{
	}

	public void EJLNJBABIII()
	{
	}

	public override void OBEJFFEJOBJ()
	{
		base.FMAFBLKAJDF();
	}

	public void JFMNHONHCFK(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void LLFFIFIFFJO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1711f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void CEAOCHPLCMC()
	{
		base.POHMFMNEPKK();
	}

	public void GDPCMFMNHND(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void PJHNHAOMDIK(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void GEPELODHBFN()
	{
		base.BODPLDJLFCF();
	}

	public override void NELFFHHCADM()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(387f, 1300f, 263f, 1309f);
		color = new Color(1973f, 205f, 903f);
		colorLerp = 690f;
	}

	public void PBDFOPCFKEA(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void HLDFOJMHKNL()
	{
		base.LEAHIBJDMBI();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void PMLPJADKFMG()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1904f, 166f, 1885f, 1379f);
		color = new Color(1213f, 1691f, 1847f);
		colorLerp = 1618f;
	}

	public override void OJBFBLHIEBB()
	{
		base.Awake();
	}

	public override void MKKJICPMPHK()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void KFAODNHBFJD()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1101f, 1948f, 82f, 772f);
		color = new Color(806f, 1413f, 938f);
		colorLerp = 1613f;
	}

	public override void CFCFDBDDANE()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(178f, 186f, 622f, 781f);
		color = new Color(76f, 1498f, 1329f);
		colorLerp = 1585f;
	}

	public override void JHPDFCAGCHC()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1819f, 1389f, 152f, 869f);
		color = new Color(1023f, 1367f, 1155f);
		colorLerp = 333f;
	}

	public void JFBHGCGALEO(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void MBGGKLDJICH()
	{
	}

	public override void EGFBPCMCNDJ()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(257f, 564f, 1359f, 1284f);
		color = new Color(280f, 356f, 129f);
		colorLerp = 1747f;
	}

	public void DJLKMCGBEPM(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1644f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void COGBDFKOHKK()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void JHPKLGGMCBL()
	{
		base.POHMFMNEPKK();
	}

	public void OFAEFKJBKBP(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 288f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void MMPOJCFOGJJ()
	{
		base.BODPLDJLFCF();
	}

	public void CNLODIEJDJJ()
	{
	}

	public override void BDBFMPGAKCE()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void OHHGKFAINEM()
	{
	}

	public void GGFFDJALCEK()
	{
	}

	public override void IAPOBEGCHLG()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(324f, 1449f, 189f, 1587f);
		color = new Color(1755f, 455f, 596f);
		colorLerp = 139f;
	}

	public override void FKDHFNCOKAK()
	{
		base.BODPLDJLFCF();
	}

	public override void ELJPNLNELIE()
	{
		base.FMAFBLKAJDF();
	}

	public void BCEAACKJJOK()
	{
	}

	public override void FJHFOBHJEHL()
	{
		base.BGFJOEPFOPM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void GAPJOLFEGKG()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1357f, 484f, 1785f, 433f);
		color = new Color(1534f, 347f, 1378f);
		colorLerp = 1676f;
	}

	public override void KMEFHCDNDNF()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1457f, 624f, 1411f, 769f);
		color = new Color(352f, 1873f, 1530f);
		colorLerp = 1214f;
	}

	public void MPEBFEPFDGO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 737f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void BGDONBMDPGM()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void KFACDBHDAOD()
	{
		base.BGFJOEPFOPM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void HCINDPKOONI()
	{
	}

	public override void KKLMPKLKAEM()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void EDDAFPDCPAP()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(433f, 594f, 110f, 1832f);
		color = new Color(117f, 32f, 712f);
		colorLerp = 11f;
	}

	public void AIBHDMEFAIL()
	{
	}

	public void HDFOEMCOGLG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 601f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void EAFOFKPGNOB()
	{
	}

	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 0f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void KKLFCDNEONL()
	{
	}

	public override void CPCDFMMLHLO()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void LPMINJJPDCH()
	{
		base.BGFJOEPFOPM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void Beat()
	{
	}

	public void PGNPMEFOLEI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1503f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void JBNPEHMDCMI()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void LMBDNPLDGIJ()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void BHCCNFJKGPD()
	{
		base.Awake();
	}

	public void KJIKPOADNHN(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void GPHMOJOGAAL(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void LNJJNMDEJBB()
	{
	}

	public void CDIJMJINOKC(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void IBFJAOINHMK()
	{
		base.LEAHIBJDMBI();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void MMPPGDECEHO()
	{
		base.FMAFBLKAJDF();
	}

	public void CJKPKCJNAPK(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 507f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void OHFOBDIAKLB(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void IJGIDGBPCFO(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void HKMBPCOECAK()
	{
	}

	public void SetResource(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void IOFCBLHLCBB()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1270f, 401f, 1441f, 378f);
		color = new Color(40f, 788f, 3f);
		colorLerp = 1399f;
	}

	public override void OGAMGLEAOAF()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1766f, 121f, 1761f, 1387f);
		color = new Color(454f, 91f, 890f);
		colorLerp = 997f;
	}

	public override void LIFEOKGNBFP()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(527f, 598f, 1663f, 692f);
		color = new Color(561f, 1948f, 869f);
		colorLerp = 808f;
	}

	public override void KAMMKPFNJJF()
	{
		base.FMAFBLKAJDF();
	}

	public override void Update()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void FDCKGNNIBHD()
	{
	}

	public void JLMFLJLPFGO(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void Reset()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1f, 1f, 1f, 0f);
		color = new Color(1f, 1f, 1f);
		colorLerp = 10f;
	}

	public void AEFEPDPHJLG(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void HFHDOJEFGJP()
	{
	}

	public override void IKKPINNOOLG()
	{
		base.POHMFMNEPKK();
	}

	public void KJJFIHEIDHI()
	{
	}

	public void LFCICDOHHLG()
	{
	}

	public override void LJEFMGOBKGE()
	{
		base.Awake();
	}

	public void EMIMOLIMHIF()
	{
	}

	public override void OLCEINJKJEI()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1097f, 536f, 1514f, 1488f);
		color = new Color(661f, 973f, 1296f);
		colorLerp = 905f;
	}

	public void NNBEJPPKIKJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 480f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void EFCLMLCDCBF()
	{
	}

	public void NIFDEAMABDD()
	{
	}

	public override void AEKNOMCLJPG()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(998f, 1082f, 1412f, 520f);
		color = new Color(1972f, 1606f, 816f);
		colorLerp = 815f;
	}

	public override void JGMEKCFHGLE()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void MBCDCBCLMCI()
	{
		base.POHMFMNEPKK();
	}

	public override void LMADKINICIN()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void BBKCPMDFNLO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1924f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void KDILIOBLILP(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void KCDOMIJBFLL()
	{
		base.LEAHIBJDMBI();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void EJLGIEFBMCF(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1565f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void FLNGIBAEAHM()
	{
	}

	public void GNFAHKAJHNH(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void GIOMPODEFJN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 27f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void IDOFOCOFEIE()
	{
		base.OGAMGLEAOAF();
		rend.sprite = null;
		rend.color = new Color(1844f, 44f, 1491f, 439f);
		color = new Color(782f, 928f, 764f);
		colorLerp = 1111f;
	}

	public void FPCGJIPMELN()
	{
	}

	public override void CCDNJPNLGBN()
	{
		base.FMAFBLKAJDF();
	}

	public void NBLPJHEGPDB(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 293f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void JGJGHFCNFMA(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void DGCGGKMNPLD()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void FMAFBLKAJDF()
	{
		base.Awake();
	}

	public override void HDDECCMEJKA()
	{
		base.AEIJFLJEABG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void DJDMFNNGAGD(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}
}
