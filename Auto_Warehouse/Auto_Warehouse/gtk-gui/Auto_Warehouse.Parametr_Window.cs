
// This file has been generated by the GUI designer. Do not modify.
namespace Auto_Warehouse
{
	public partial class Parametr_Window
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Entry tb_Code;
		
		private global::Gtk.Entry tb_Count;
		
		private global::Gtk.Entry tb_Name;
		
		private global::Gtk.Entry tb_Parametr;
		
		private global::Gtk.Entry tb_ParametrValue;
		
		private global::Gtk.Entry tb_PriceForOne;
		
		private global::Gtk.Entry tb_Producer;
		
		private global::Gtk.Entry tb_TypeCount;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Auto_Warehouse.Parametr_Window
			this.Name = "Auto_Warehouse.Parametr_Window";
			this.Title = global::Mono.Unix.Catalog.GetString ("Параметры");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child Auto_Warehouse.Parametr_Window.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(8)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Название");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Производитель");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Параметр");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Значение параметра");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w5.TopAttach = ((uint)(4));
			w5.BottomAttach = ((uint)(5));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Единица измерения");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w6.TopAttach = ((uint)(5));
			w6.BottomAttach = ((uint)(6));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Количество");
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label7]));
			w7.TopAttach = ((uint)(6));
			w7.BottomAttach = ((uint)(7));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Цена за единицу");
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
			w8.TopAttach = ((uint)(7));
			w8.BottomAttach = ((uint)(8));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tb_Code = new global::Gtk.Entry ();
			this.tb_Code.CanFocus = true;
			this.tb_Code.Name = "tb_Code";
			this.tb_Code.IsEditable = true;
			this.tb_Code.InvisibleChar = '•';
			this.table1.Add (this.tb_Code);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.tb_Code]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tb_Count = new global::Gtk.Entry ();
			this.tb_Count.CanFocus = true;
			this.tb_Count.Name = "tb_Count";
			this.tb_Count.IsEditable = true;
			this.tb_Count.InvisibleChar = '•';
			this.table1.Add (this.tb_Count);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.tb_Count]));
			w10.TopAttach = ((uint)(6));
			w10.BottomAttach = ((uint)(7));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tb_Name = new global::Gtk.Entry ();
			this.tb_Name.CanFocus = true;
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.IsEditable = true;
			this.tb_Name.InvisibleChar = '•';
			this.table1.Add (this.tb_Name);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.tb_Name]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tb_Parametr = new global::Gtk.Entry ();
			this.tb_Parametr.CanFocus = true;
			this.tb_Parametr.Name = "tb_Parametr";
			this.tb_Parametr.IsEditable = true;
			this.tb_Parametr.InvisibleChar = '•';
			this.table1.Add (this.tb_Parametr);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.tb_Parametr]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tb_ParametrValue = new global::Gtk.Entry ();
			this.tb_ParametrValue.CanFocus = true;
			this.tb_ParametrValue.Name = "tb_ParametrValue";
			this.tb_ParametrValue.IsEditable = true;
			this.tb_ParametrValue.InvisibleChar = '•';
			this.table1.Add (this.tb_ParametrValue);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.tb_ParametrValue]));
			w13.TopAttach = ((uint)(4));
			w13.BottomAttach = ((uint)(5));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tb_PriceForOne = new global::Gtk.Entry ();
			this.tb_PriceForOne.CanFocus = true;
			this.tb_PriceForOne.Name = "tb_PriceForOne";
			this.tb_PriceForOne.IsEditable = true;
			this.tb_PriceForOne.InvisibleChar = '•';
			this.table1.Add (this.tb_PriceForOne);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.tb_PriceForOne]));
			w14.TopAttach = ((uint)(7));
			w14.BottomAttach = ((uint)(8));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tb_Producer = new global::Gtk.Entry ();
			this.tb_Producer.CanFocus = true;
			this.tb_Producer.Name = "tb_Producer";
			this.tb_Producer.IsEditable = true;
			this.tb_Producer.InvisibleChar = '•';
			this.table1.Add (this.tb_Producer);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.tb_Producer]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tb_TypeCount = new global::Gtk.Entry ();
			this.tb_TypeCount.CanFocus = true;
			this.tb_TypeCount.Name = "tb_TypeCount";
			this.tb_TypeCount.IsEditable = true;
			this.tb_TypeCount.InvisibleChar = '•';
			this.table1.Add (this.tb_TypeCount);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.tb_TypeCount]));
			w16.TopAttach = ((uint)(5));
			w16.BottomAttach = ((uint)(6));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 314;
			this.DefaultHeight = 266;
			this.Show ();
		}
	}
}
