
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.Fixed fixed3;
	private global::Gtk.Button button6;
	private global::Gtk.DrawingArea mainDraw;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed3 = new global::Gtk.Fixed ();
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.button6 = new global::Gtk.Button ();
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.fixed3.Add (this.button6);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed3 [this.button6]));
		w1.X = 18;
		w1.Y = 620;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.mainDraw = new global::Gtk.DrawingArea ();
		this.mainDraw.WidthRequest = 800;
		this.mainDraw.HeightRequest = 600;
		this.mainDraw.Name = "mainDraw";
		this.fixed3.Add (this.mainDraw);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed3 [this.mainDraw]));
		w2.X = 10;
		w2.Y = 10;
		this.Add (this.fixed3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1000;
		this.DefaultHeight = 664;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button6.Clicked += new global::System.EventHandler (this.Click_Handler);
	}
}