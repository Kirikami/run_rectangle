
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.DrawingArea drawGraph;
	
	private global::Gtk.VBox vbox4;
	
	private global::Gtk.Label timeText;
	
	private global::Gtk.Entry timeForRunning;
	
	private global::Gtk.Button runRectangle;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(24));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.drawGraph = new global::Gtk.DrawingArea ();
		this.drawGraph.Name = "drawGraph";
		this.vbox3.Add (this.drawGraph);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.drawGraph]));
		w1.Position = 0;
		this.hbox5.Add (this.vbox3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.vbox3]));
		w2.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.timeText = new global::Gtk.Label ();
		this.timeText.Name = "timeText";
		this.timeText.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter time for running rectangle\n");
		this.vbox4.Add (this.timeText);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.timeText]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.timeForRunning = new global::Gtk.Entry ();
		this.timeForRunning.CanFocus = true;
		this.timeForRunning.Name = "timeForRunning";
		this.timeForRunning.IsEditable = true;
		this.timeForRunning.InvisibleChar = '●';
		this.vbox4.Add (this.timeForRunning);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.timeForRunning]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.runRectangle = new global::Gtk.Button ();
		this.runRectangle.CanFocus = true;
		this.runRectangle.Name = "runRectangle";
		this.runRectangle.UseStock = true;
		this.runRectangle.UseUnderline = true;
		this.runRectangle.Label = "gtk-media-play";
		this.vbox4.Add (this.runRectangle);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.runRectangle]));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		this.hbox5.Add (this.vbox4);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.vbox4]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		this.Add (this.hbox5);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 896;
		this.DefaultHeight = 607;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.runRectangle.Clicked += new global::System.EventHandler (this.OnRunRectangleClicked);
	}
}
