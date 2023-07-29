// EditorCaret
using UnityEngine;

public class EditorCaret : MonoBehaviour
{
	private MapEditor LBFPCCEFBBL;

	private Vector3 CPCNODILEAE;

	public float z;

	public float lerpSpeed = 5f;

	public int asourceid;

	public bool moveOnlyWhenPlaying;

	public bool forcePosition;

	public bool useScale = true;

	public float scaleSize = 1f;

	private float CGCGPJAEDII;

	private void AGMJDGHLBMN()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 422f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1191f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 14, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-40) : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-36), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-109), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void IDIIELPAMCJ()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1728f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 741f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : (-37), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-27), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 23, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 20 : 0, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void BGFJOEPFOPM()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 49f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1719f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 80, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-116), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-7), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-83), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void JILOMOBDPIA()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void FABKIGNFECE()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1673f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 312f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 16, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-123), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-98), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-26), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void FEHCNJLLJMP()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void JAAJECBCCFM()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 326f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1681f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-96), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-106), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-104), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 77, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void KLILJHJNICK()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void NNCCPEBIAKH()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void GHILDCBCDJI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1968f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1163f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 63, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 110 : 0, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 57, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-9), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void LEAHIBJDMBI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 297f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 971f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-115), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 114, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-24), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-72), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void KIMMMCJFMAB()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void Start()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void ONMGIPAILOH()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 294f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1624f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 72, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : (-21), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 69, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-102), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void Update()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 30f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 0f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-2), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-2), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-2), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-2), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void AAPKBNDHBLI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1979f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1000f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-3), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-46), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? (-44) : 0, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 116, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void JOACBIEHHCE()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 710f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1302f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 44, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-30), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 53, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-16), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void NCNPAKFAFOE()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void NBGIMIDICKE()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void AIJGAJIOJDJ()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1360f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 607f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-126), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 97, z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-92), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-128), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void CCLNNLCOPBL()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void MFMIODIAKNI()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 720f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 259f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 19, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-69), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-58), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-16), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void KCDOMIJBFLL()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 991f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 378f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 22, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-1), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 63, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId == 0) ? 22 : 0, z), Time.deltaTime * lerpSpeed);
		}
	}

	private void NKLIHNJCHOG()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 224f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 853f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 52, Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : (-22), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 125, Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : (-57), z), Time.deltaTime * lerpSpeed);
		}
	}

	private void KDMANOEMOCA()
	{
		LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		CPCNODILEAE = base.transform.localScale;
	}

	private void LLJLDLLNFBH()
	{
		if (useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 51f * scaleSize, CPCNODILEAE.y, CPCNODILEAE.z);
		}
		if (!(lerpSpeed > 1231f))
		{
			return;
		}
		float num = Mathf.Lerp(base.transform.position.x, LBFPCCEFBBL.currentTime, Time.deltaTime * lerpSpeed);
		if (moveOnlyWhenPlaying)
		{
			if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying)
			{
				if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
				{
					base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : (-94), Time.deltaTime * lerpSpeed), z);
				}
				else
				{
					base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : (-75), z), Time.deltaTime * lerpSpeed);
				}
			}
		}
		else if (LBFPCCEFBBL.audioSampler.audioSources[asourceid].isPlaying && forcePosition)
		{
			base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : (-58), Time.deltaTime * lerpSpeed), z);
		}
		else
		{
			base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : (-92), z), Time.deltaTime * lerpSpeed);
		}
	}
}
