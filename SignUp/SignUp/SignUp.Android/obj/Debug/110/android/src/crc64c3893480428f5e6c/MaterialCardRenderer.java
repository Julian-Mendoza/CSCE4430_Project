package crc64c3893480428f5e6c;


public class MaterialCardRenderer
	extends crc64720bb2db43a66fe9.FrameRenderer
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnTouchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouch:(Landroid/view/View;Landroid/view/MotionEvent;)Z:GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("XF.Material.Droid.Renderers.MaterialCardRenderer, XF.Material", MaterialCardRenderer.class, __md_methods);
	}


	public MaterialCardRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialCardRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialCardRenderer, XF.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MaterialCardRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialCardRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialCardRenderer, XF.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialCardRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialCardRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialCardRenderer, XF.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean onTouch (android.view.View p0, android.view.MotionEvent p1)
	{
		return n_onTouch (p0, p1);
	}

	private native boolean n_onTouch (android.view.View p0, android.view.MotionEvent p1);

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
