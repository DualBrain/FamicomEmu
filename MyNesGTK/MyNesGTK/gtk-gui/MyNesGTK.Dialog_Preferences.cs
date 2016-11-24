
// This file has been generated by the GUI designer. Do not modify.
namespace MyNesGTK
{
	public partial class Dialog_Preferences
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.Button button98;
		
		private global::Gtk.CheckButton checkbutton_connectFourPlayers;
		
		private global::Gtk.CheckButton checkbutton_connectZapper;
		
		private global::Gtk.CheckButton checkbutton_saveSram;
		
		private global::Gtk.CheckButton checkbutton_snapReplace;
		
		private global::Gtk.ComboBox combobox_region;
		
		private global::Gtk.ComboBox combobox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MyNesGTK.Dialog_Preferences
			this.Name = "MyNesGTK.Dialog_Preferences";
			this.Title = global::Mono.Unix.Catalog.GetString ("Preferences");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("MyNesGTK.resources.wrench.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child MyNesGTK.Dialog_Preferences.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(7)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.button98 = new global::Gtk.Button ();
			this.button98.CanFocus = true;
			this.button98.Name = "button98";
			this.button98.UseUnderline = true;
			this.button98.Label = global::Mono.Unix.Catalog.GetString ("Reset to defaults");
			this.table1.Add (this.button98);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.button98]));
			w2.TopAttach = ((uint)(6));
			w2.BottomAttach = ((uint)(7));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_connectFourPlayers = new global::Gtk.CheckButton ();
			this.checkbutton_connectFourPlayers.CanFocus = true;
			this.checkbutton_connectFourPlayers.Name = "checkbutton_connectFourPlayers";
			this.checkbutton_connectFourPlayers.Label = global::Mono.Unix.Catalog.GetString ("Start with 4 Players connected");
			this.checkbutton_connectFourPlayers.DrawIndicator = true;
			this.checkbutton_connectFourPlayers.UseUnderline = true;
			this.table1.Add (this.checkbutton_connectFourPlayers);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_connectFourPlayers]));
			w3.TopAttach = ((uint)(4));
			w3.BottomAttach = ((uint)(5));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_connectZapper = new global::Gtk.CheckButton ();
			this.checkbutton_connectZapper.CanFocus = true;
			this.checkbutton_connectZapper.Name = "checkbutton_connectZapper";
			this.checkbutton_connectZapper.Label = global::Mono.Unix.Catalog.GetString ("Start with Zapper (Light Gun) connected");
			this.checkbutton_connectZapper.DrawIndicator = true;
			this.checkbutton_connectZapper.UseUnderline = true;
			this.table1.Add (this.checkbutton_connectZapper);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_connectZapper]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_saveSram = new global::Gtk.CheckButton ();
			this.checkbutton_saveSram.CanFocus = true;
			this.checkbutton_saveSram.Name = "checkbutton_saveSram";
			this.checkbutton_saveSram.Label = global::Mono.Unix.Catalog.GetString ("Save S-RAM on emulation exit");
			this.checkbutton_saveSram.DrawIndicator = true;
			this.checkbutton_saveSram.UseUnderline = true;
			this.table1.Add (this.checkbutton_saveSram);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_saveSram]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton_snapReplace = new global::Gtk.CheckButton ();
			this.checkbutton_snapReplace.CanFocus = true;
			this.checkbutton_snapReplace.Name = "checkbutton_snapReplace";
			this.checkbutton_snapReplace.Label = global::Mono.Unix.Catalog.GetString ("Replace Snapshot instead of creating new one each time");
			this.checkbutton_snapReplace.DrawIndicator = true;
			this.checkbutton_snapReplace.UseUnderline = true;
			this.table1.Add (this.checkbutton_snapReplace);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton_snapReplace]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.combobox_region = global::Gtk.ComboBox.NewText ();
			this.combobox_region.AppendText (global::Mono.Unix.Catalog.GetString ("AUTO"));
			this.combobox_region.AppendText (global::Mono.Unix.Catalog.GetString ("NTSC"));
			this.combobox_region.AppendText (global::Mono.Unix.Catalog.GetString ("PALB"));
			this.combobox_region.AppendText (global::Mono.Unix.Catalog.GetString ("DENDY"));
			this.combobox_region.Name = "combobox_region";
			this.combobox_region.Active = 0;
			this.table1.Add (this.combobox_region);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.combobox_region]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.combobox2 = global::Gtk.ComboBox.NewText ();
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString (".png"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString (".jpg"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString (".bmp"));
			this.combobox2.Name = "combobox2";
			this.combobox2.Active = 0;
			this.table1.Add (this.combobox2);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.combobox2]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Emulation Region");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Snapshot format");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1 [this.table1]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Internal child MyNesGTK.Dialog_Preferences.ActionArea
			global::Gtk.HButtonBox w12 = this.ActionArea;
			w12.Name = "dialog1_ActionArea";
			w12.Spacing = 10;
			w12.BorderWidth = ((uint)(5));
			w12.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonCancel]));
			w13.Expand = false;
			w13.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonOk]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 471;
			this.DefaultHeight = 290;
			this.Show ();
			this.button98.Pressed += new global::System.EventHandler (this.OnButton98Pressed);
		}
	}
}
