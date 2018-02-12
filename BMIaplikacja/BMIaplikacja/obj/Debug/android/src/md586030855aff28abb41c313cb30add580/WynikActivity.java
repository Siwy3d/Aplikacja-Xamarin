package md586030855aff28abb41c313cb30add580;


public class WynikActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("BMIaplikacja.WynikActivity, BMIaplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WynikActivity.class, __md_methods);
	}


	public WynikActivity ()
	{
		super ();
		if (getClass () == WynikActivity.class)
			mono.android.TypeManager.Activate ("BMIaplikacja.WynikActivity, BMIaplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
