package crc6470839963d44a8e23;


public class MaterialEntryRenderer
	extends crc643f46942d9dd1fff9.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XF.Material.Droid.Renderers.Internals.MaterialEntryRenderer, XF.Material", MaterialEntryRenderer.class, __md_methods);
	}


	public MaterialEntryRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialEntryRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.Internals.MaterialEntryRenderer, XF.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MaterialEntryRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialEntryRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.Internals.MaterialEntryRenderer, XF.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialEntryRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialEntryRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.Internals.MaterialEntryRenderer, XF.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
