// SpriteController
using UnityEngine;
using UnityEngine.UI;

public class SpriteController : EnvironmentController
{
	public Color color = new Color(1f, 1f, 1f);

	public float colorLerp = 10f;

	[SerializeField]
	private Image rend;

	public void BGJFENIEABH(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 198f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void BGFCMMDKCOI()
	{
		base.FMAFBLKAJDF();
	}

	public void AOMBECMLHAE(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void IHFFLDHCKFB()
	{
		base.EEBGCGFNELO();
		rend.sprite = null;
		rend.color = new Color(1815f, 26f, 1095f, 1027f);
		color = new Color(24f, 895f, 1887f);
		colorLerp = 1064f;
	}

	public override void HPNNCNNFMGK()
	{
		base.BGDONBMDPGM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void EIJCNIHOHME(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 425f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void JBIFKBNPHJE()
	{
		base.OPFDGBDADMA();
	}

	public void CDJOFPGFPPJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 666f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void GAOMPMFOJNC()
	{
		base.EEBGCGFNELO();
		rend.sprite = null;
		rend.color = new Color(857f, 1815f, 836f, 692f);
		color = new Color(1180f, 1551f, 1525f);
		colorLerp = 60f;
	}

	public void CNBBLHADCCK(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void AOELLGPDHIG(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void HLDFOJMHKNL()
	{
		base.BMODOIJGIOO();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void PMLIOODCKDB()
	{
		base.IJFMKNEPKEJ();
		rend.sprite = null;
		rend.color = new Color(957f, 954f, 1945f, 404f);
		color = new Color(167f, 28f, 1601f);
		colorLerp = 539f;
	}

	public void HBJDEEKPPFI(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void CKCPHFLOLAH()
	{
		base.IJFMKNEPKEJ();
		rend.sprite = null;
		rend.color = new Color(951f, 184f, 517f, 1276f);
		color = new Color(1529f, 1503f, 1720f);
		colorLerp = 982f;
	}

	public override void HCCMANDFEPL()
	{
		base.NLNAJMCBNDC();
	}

	public void MPEBFEPFDGO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1870f)
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

	public override void IPJENEAMGBP()
	{
		base.EMANBHKAONB();
	}

	public void GMGGCHGJMLK(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1032f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void BGFJOEPFOPM()
	{
		base.NKLIHNJCHOG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void FGNFILLNPJK()
	{
		base.BGDONBMDPGM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void MFAMHKBMBEI()
	{
		base.EMANBHKAONB();
	}

	public void LHJIFENNPHP(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1178f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void Update()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void MNPNHJJCCKP(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 644f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void MANOCIJICLG()
	{
		base.CAPPKCBFILL();
		rend.sprite = null;
		rend.color = new Color(1486f, 1627f, 1741f, 209f);
		color = new Color(653f, 220f, 722f);
		colorLerp = 1234f;
	}

	public void HFHDOJEFGJP()
	{
	}

	public override void GCNKABKPNOJ()
	{
		base.IOMCHHBGJEC();
	}

	public void NNJDLOMPDCD()
	{
	}

	public override void EPJJDKJEDMM()
	{
		base.CFIAKIJAILI();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void AFJHIDEHKME(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void KEKNHAAEPCJ()
	{
		base.HBPLJMJAAHK();
	}

	public void ICCHHDIKCIM(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 904f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void MANDOGNJJBD()
	{
		base.BGDONBMDPGM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void GGHEPDCEHCK()
	{
		base.OKADMJFLMGP();
	}

	public override void JDGFCEPDKAJ()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void DMIKIDGJEFC()
	{
		base.OPFDGBDADMA();
	}

	public override void KGMCGGIEPDE()
	{
		base.IOMCHHBGJEC();
	}

	public override void MBCDCBCLMCI()
	{
		base.OLFNCABJBHA();
	}

	public override void LKJMIODJGCM()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void LCJHDLKJEOM()
	{
		base.EHCGBJDFMHG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void NOBIKMKFADE(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 463f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void IEMEHGCFAPD()
	{
		base.NKLIHNJCHOG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void DAOMCMCNAPA()
	{
	}

	public void JIIHIBBGAFD(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 898f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void NLBAJOJIHGM()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1332f, 215f, 880f, 1866f);
		color = new Color(1995f, 632f, 1789f);
		colorLerp = 797f;
	}

	public void KMBLNBPOKNC(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1494f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void PKEPMIDKCEN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1891f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void JNBMKLFJCEM()
	{
		base.EMANBHKAONB();
	}

	public override void KNNOEGLLDAN()
	{
		base.EEBGCGFNELO();
		rend.sprite = null;
		rend.color = new Color(716f, 114f, 1195f, 617f);
		color = new Color(665f, 1543f, 836f);
		colorLerp = 1324f;
	}

	public void GOFKPNOIKKL(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1674f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void IJFMKNEPKEJ()
	{
		base.EEBGCGFNELO();
		rend.sprite = null;
		rend.color = new Color(708f, 804f, 1411f, 1674f);
		color = new Color(1428f, 1559f, 1245f);
		colorLerp = 1016f;
	}

	public override void NEEIFNDHDOG()
	{
		base.IOMCHHBGJEC();
	}

	public override void EHKAMNFEGMG()
	{
		base.FAAJAMIGJNK();
	}

	public void NJLCAFJKJDD(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void HIGGFNEIAME()
	{
	}

	public void GHMCBHOHGIG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1777f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void BJHJCGJACEA()
	{
		base.EGFBPCMCNDJ();
		rend.sprite = null;
		rend.color = new Color(756f, 1258f, 1826f, 864f);
		color = new Color(1049f, 52f, 281f);
		colorLerp = 388f;
	}

	public void FELMKMFBCBE(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void ABEKLGOFNGE()
	{
	}

	public void JKEEMKMDODH()
	{
	}

	public void EKJFDPCNLFG()
	{
	}

	public override void EEBGCGFNELO()
	{
		base.LAACNNJDKBI();
		rend.sprite = null;
		rend.color = new Color(1869f, 672f, 373f, 1352f);
		color = new Color(1445f, 1280f, 1835f);
		colorLerp = 6f;
	}

	public void MBCPEFPIAFA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 781f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void Beat()
	{
	}

	public void NNDHBHENPAD(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1545f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void BDHJEDNAKNO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1256f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void GEOKLLPCCBP(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void DFJIKJIKHHF()
	{
	}

	public override void POEMOLBJDLG()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void GAHBKBDGHHK()
	{
	}

	public override void MECJHOJPODB()
	{
		base.EHCGBJDFMHG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void GHJABJOMENO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 370f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public override void BJIKAHNJNEB()
	{
		base.EEBGCGFNELO();
		rend.sprite = null;
		rend.color = new Color(1213f, 690f, 1467f, 595f);
		color = new Color(1081f, 881f, 1313f);
		colorLerp = 1107f;
	}

	public void HFPGNLAHEKJ(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 65f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void NLDMNCELHEG()
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

	public override void OGAMGLEAOAF()
	{
		base.CKCPHFLOLAH();
		rend.sprite = null;
		rend.color = new Color(161f, 1149f, 1113f, 529f);
		color = new Color(1685f, 380f, 1453f);
		colorLerp = 1000f;
	}

	public override void GGHCBIAEBBH()
	{
		base.EEBGCGFNELO();
		rend.sprite = null;
		rend.color = new Color(1809f, 768f, 114f, 939f);
		color = new Color(236f, 1924f, 392f);
		colorLerp = 724f;
	}

	public override void NKHLPNAMBEH()
	{
		base.EGFBPCMCNDJ();
		rend.sprite = null;
		rend.color = new Color(1249f, 1343f, 1920f, 1177f);
		color = new Color(1611f, 1754f, 1172f);
		colorLerp = 281f;
	}

	public override void JBCNIPJDPJB()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public override void JBNPEHMDCMI()
	{
		base.NKLIHNJCHOG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void OBPKFIMEILG(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void HEBOIFKBLGD()
	{
		base.CFIAKIJAILI();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void DDDHIOHDKFK()
	{
	}

	public override void LFFAKAOAOCN()
	{
		base.OPFDGBDADMA();
	}

	public override void COABGLMKACM()
	{
		base.EGFBPCMCNDJ();
		rend.sprite = null;
		rend.color = new Color(514f, 1561f, 1339f, 683f);
		color = new Color(280f, 1900f, 1781f);
		colorLerp = 754f;
	}

	public void KIIKBCGEBEM(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void JHAPJAIDFLA()
	{
	}

	public override void IKKPINNOOLG()
	{
		base.IOMCHHBGJEC();
	}

	public override void FPAFACCBEGA()
	{
		base.LAACNNJDKBI();
		rend.sprite = null;
		rend.color = new Color(277f, 1106f, 323f, 115f);
		color = new Color(1269f, 232f, 593f);
		colorLerp = 1502f;
	}

	public void EEEAJKIJMKJ()
	{
	}

	public override void Reset()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1f, 1f, 1f, 0f);
		color = new Color(1f, 1f, 1f);
		colorLerp = 10f;
	}

	public override void BANHFNDEPPO()
	{
		base.EMANBHKAONB();
	}

	public override void OMCLOFCJMPG()
	{
		base.BGDONBMDPGM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void GJBOLGFMMLJ()
	{
	}

	public override void IAPOBEGCHLG()
	{
		base.Reset();
		rend.sprite = null;
		rend.color = new Color(1900f, 1680f, 1425f, 442f);
		color = new Color(683f, 1184f, 826f);
		colorLerp = 1542f;
	}

	public void ALLNACKDLHD()
	{
	}

	public override void CCDNJPNLGBN()
	{
		base.FAAJAMIGJNK();
	}

	public override void GOBHPAJFFDB()
	{
		base.OKADMJFLMGP();
	}

	public override void CJEDMGCKHBI()
	{
		base.IOMCHHBGJEC();
	}

	public override void JOPOMLLAMKE()
	{
		base.CEACMFGNDEB();
		rend.sprite = null;
		rend.color = new Color(852f, 828f, 1728f, 16f);
		color = new Color(1624f, 1859f, 149f);
		colorLerp = 1368f;
	}

	public void NNDAJNEINKI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 821f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void CKBAOCMBHPM(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void BPBMKAEMIJC(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void FDCDJLFLLCP()
	{
	}

	public void OJPKELPDJKA(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void DPDLNNOJNKP(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void FCMKJBCAJFN(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 981f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void KBIBAIKLKGC(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void PBEPCAPAKLG()
	{
		base.Update();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void AOLBEALJOOO(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void GCHBGCGBMCK()
	{
		base.NKLIHNJCHOG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void KMLICCOAHCJ()
	{
	}

	public override void AGMJDGHLBMN()
	{
		base.BGDONBMDPGM();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void DPOGDACJIMM(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 1947f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void KNNJJLIOLFA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		if (MNHBOECHFEG > 198f)
		{
			colorLerp = MNHBOECHFEG;
		}
		else
		{
			rend.color = HABLFKCCKLN;
		}
	}

	public void INECNDJKNKH(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void ONMGIPAILOH()
	{
		base.EHCGBJDFMHG();
		rend.color = Color.Lerp(rend.color, color, Time.smoothDeltaTime * colorLerp);
	}

	public void PGODLFEBOCJ(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public void SetResource(Sprite LKCFNGIBLOF)
	{
		rend.sprite = LKCFNGIBLOF;
	}

	public override void Awake()
	{
		base.Awake();
	}
}
