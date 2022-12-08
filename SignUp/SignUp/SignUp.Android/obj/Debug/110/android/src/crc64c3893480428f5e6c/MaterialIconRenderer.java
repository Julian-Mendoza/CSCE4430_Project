package crc64c3893480428f5e6c;


public class MaterialIconRenderer
	extends crc643f46942d9dd1fff9.ImageRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XF.Material.Droid.Renderers.MaterialIconRenderer, XF.Material", MaterialIconRenderer.class, __md_methods);
	}


	public MaterialIconRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialIconRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialIconRenderer, XF.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MaterialIconRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialIconRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialIconRenderer, XF.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialIconRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialIconRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialIconRenderer, XF.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
