namespace AppelSync
{
    partial class Interface
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.CancionesTabla = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trackViewElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PesoLista = new System.Windows.Forms.Label();
            this.PesoListas = new System.Windows.Forms.Label();
            this.TablaListas = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listTrackViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SyncroFeed = new System.Windows.Forms.Label();
            this.pathSyncro = new System.Windows.Forms.Label();
            this.PathitunesXML = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CancionesLabel = new System.Windows.Forms.Label();
            this.DestinoButton = new FontAwesome.Sharp.IconButton();
            this.itunesButton = new FontAwesome.Sharp.IconButton();
            this.SyncroButton = new FontAwesome.Sharp.IconButton();
            this.HelpBTTN = new FontAwesome.Sharp.IconButton();
            this.feedFromTrackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CancionesTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackViewElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaListas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTrackViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedFromTrackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CancionesTabla
            // 
            this.CancionesTabla.AllowUserToAddRows = false;
            this.CancionesTabla.AllowUserToDeleteRows = false;
            this.CancionesTabla.AutoGenerateColumns = false;
            this.CancionesTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CancionesTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CancionesTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CancionesTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancionesTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn1});
            this.CancionesTabla.DataSource = this.trackViewElementBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CancionesTabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.CancionesTabla.EnableHeadersVisualStyles = false;
            this.CancionesTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.CancionesTabla.Location = new System.Drawing.Point(593, 183);
            this.CancionesTabla.Name = "CancionesTabla";
            this.CancionesTabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CancionesTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CancionesTabla.RowHeadersWidth = 82;
            this.CancionesTabla.RowTemplate.Height = 35;
            this.CancionesTabla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CancionesTabla.Size = new System.Drawing.Size(756, 655);
            this.CancionesTabla.TabIndex = 2;
            this.CancionesTabla.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CancionesTabla_CellMouseClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreDataGridViewTextBoxColumn.ToolTipText = "Nombre de La Cancion";
            // 
            // activeDataGridViewCheckBoxColumn1
            // 
            this.activeDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activeDataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn1.HeaderText = "Sync.";
            this.activeDataGridViewCheckBoxColumn1.MinimumWidth = 10;
            this.activeDataGridViewCheckBoxColumn1.Name = "activeDataGridViewCheckBoxColumn1";
            this.activeDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.activeDataGridViewCheckBoxColumn1.ToolTipText = "Marcar Para Sincronizar la Cancion";
            this.activeDataGridViewCheckBoxColumn1.Width = 94;
            // 
            // trackViewElementBindingSource
            // 
            this.trackViewElementBindingSource.DataSource = typeof(AppelSync.Modelos.TrackViewElement);
            // 
            // PesoLista
            // 
            this.PesoLista.Location = new System.Drawing.Point(1180, 152);
            this.PesoLista.Name = "PesoLista";
            this.PesoLista.Size = new System.Drawing.Size(169, 25);
            this.PesoLista.TabIndex = 3;
            this.PesoLista.Text = "Total 0 MB";
            this.PesoLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PesoListas
            // 
            this.PesoListas.Location = new System.Drawing.Point(401, 152);
            this.PesoListas.Name = "PesoListas";
            this.PesoListas.Size = new System.Drawing.Size(156, 25);
            this.PesoListas.TabIndex = 4;
            this.PesoListas.Text = "Total 0 MB";
            this.PesoListas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TablaListas
            // 
            this.TablaListas.AllowUserToAddRows = false;
            this.TablaListas.AllowUserToDeleteRows = false;
            this.TablaListas.AutoGenerateColumns = false;
            this.TablaListas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(222)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaListas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaListas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.TablaListas.DataSource = this.listTrackViewBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaListas.DefaultCellStyle = dataGridViewCellStyle5;
            this.TablaListas.EnableHeadersVisualStyles = false;
            this.TablaListas.Location = new System.Drawing.Point(23, 183);
            this.TablaListas.Name = "TablaListas";
            this.TablaListas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaListas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TablaListas.RowHeadersWidth = 82;
            this.TablaListas.RowTemplate.Height = 35;
            this.TablaListas.Size = new System.Drawing.Size(534, 655);
            this.TablaListas.TabIndex = 5;
            this.TablaListas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablaListas_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.ToolTipText = "Lista de Reproduccion Encontrada en la Libreria iTunes";
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Sync.";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.activeDataGridViewCheckBoxColumn.ToolTipText = "Marcar Para Sincronizar";
            this.activeDataGridViewCheckBoxColumn.Width = 94;
            // 
            // listTrackViewBindingSource
            // 
            this.listTrackViewBindingSource.DataSource = typeof(AppelSync.Modelos.ListTrackView);
            // 
            // SyncroFeed
            // 
            this.SyncroFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.SyncroFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SyncroFeed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SyncroFeed.Location = new System.Drawing.Point(158, 854);
            this.SyncroFeed.Name = "SyncroFeed";
            this.SyncroFeed.Size = new System.Drawing.Size(1000, 50);
            this.SyncroFeed.TabIndex = 7;
            this.SyncroFeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pathSyncro
            // 
            this.pathSyncro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pathSyncro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pathSyncro.Location = new System.Drawing.Point(186, 77);
            this.pathSyncro.Name = "pathSyncro";
            this.pathSyncro.Size = new System.Drawing.Size(1000, 50);
            this.pathSyncro.TabIndex = 9;
            this.pathSyncro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PathitunesXML
            // 
            this.PathitunesXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.PathitunesXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.PathitunesXML.Location = new System.Drawing.Point(186, 12);
            this.PathitunesXML.Name = "PathitunesXML";
            this.PathitunesXML.Size = new System.Drawing.Size(1000, 50);
            this.PathitunesXML.TabIndex = 11;
            this.PathitunesXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Listas de Reproducción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancionesLabel
            // 
            this.CancionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancionesLabel.Location = new System.Drawing.Point(591, 143);
            this.CancionesLabel.Name = "CancionesLabel";
            this.CancionesLabel.Size = new System.Drawing.Size(548, 37);
            this.CancionesLabel.TabIndex = 13;
            this.CancionesLabel.Text = "Canciones";
            this.CancionesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DestinoButton
            // 
            this.DestinoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.DestinoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            this.DestinoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestinoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.DestinoButton.IconChar = FontAwesome.Sharp.IconChar.Usb;
            this.DestinoButton.IconColor = System.Drawing.Color.Black;
            this.DestinoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DestinoButton.IconSize = 35;
            this.DestinoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DestinoButton.Location = new System.Drawing.Point(23, 77);
            this.DestinoButton.Name = "DestinoButton";
            this.DestinoButton.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.DestinoButton.Size = new System.Drawing.Size(150, 50);
            this.DestinoButton.TabIndex = 16;
            this.DestinoButton.Text = "Destino";
            this.DestinoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DestinoButton.UseVisualStyleBackColor = false;
            this.DestinoButton.Click += new System.EventHandler(this.DestinoButtonClick);
            // 
            // itunesButton
            // 
            this.itunesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.itunesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            this.itunesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            this.itunesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itunesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.itunesButton.IconChar = FontAwesome.Sharp.IconChar.Apple;
            this.itunesButton.IconColor = System.Drawing.Color.Black;
            this.itunesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itunesButton.IconSize = 35;
            this.itunesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itunesButton.Location = new System.Drawing.Point(23, 12);
            this.itunesButton.Name = "itunesButton";
            this.itunesButton.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.itunesButton.Size = new System.Drawing.Size(150, 50);
            this.itunesButton.TabIndex = 17;
            this.itunesButton.Text = "iTunes";
            this.itunesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.itunesButton.UseVisualStyleBackColor = false;
            this.itunesButton.Click += new System.EventHandler(this.pathXMLButton_Click);
            // 
            // SyncroButton
            // 
            this.SyncroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(177)))));
            this.SyncroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            this.SyncroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncroButton.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.SyncroButton.IconColor = System.Drawing.Color.Black;
            this.SyncroButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SyncroButton.IconSize = 35;
            this.SyncroButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SyncroButton.Location = new System.Drawing.Point(1199, 856);
            this.SyncroButton.Name = "SyncroButton";
            this.SyncroButton.Padding = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.SyncroButton.Size = new System.Drawing.Size(150, 50);
            this.SyncroButton.TabIndex = 18;
            this.SyncroButton.Text = "Syncro";
            this.SyncroButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SyncroButton.UseVisualStyleBackColor = false;
            this.SyncroButton.Click += new System.EventHandler(this.SyncroAction);
            // 
            // HelpBTTN
            // 
            this.HelpBTTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(202)))));
            this.HelpBTTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.HelpBTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.HelpBTTN.IconChar = FontAwesome.Sharp.IconChar.SquareCaretRight;
            this.HelpBTTN.IconColor = System.Drawing.Color.Black;
            this.HelpBTTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HelpBTTN.IconSize = 35;
            this.HelpBTTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpBTTN.Location = new System.Drawing.Point(1199, 12);
            this.HelpBTTN.Name = "HelpBTTN";
            this.HelpBTTN.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.HelpBTTN.Size = new System.Drawing.Size(150, 50);
            this.HelpBTTN.TabIndex = 19;
            this.HelpBTTN.Text = "Ayuda";
            this.HelpBTTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HelpBTTN.UseVisualStyleBackColor = false;
            this.HelpBTTN.Click += new System.EventHandler(this.helpXMLButton_Click);
            // 
            // feedFromTrackBindingSource
            // 
            this.feedFromTrackBindingSource.DataSource = typeof(AppelSync.Modelos.TrackViewElement.FeedFromTrack);
            // 
            // listViewBindingSource
            // 
            this.listViewBindingSource.DataSource = typeof(AppelSync.Modelos.ListTrackView);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1374, 929);
            this.Controls.Add(this.HelpBTTN);
            this.Controls.Add(this.SyncroButton);
            this.Controls.Add(this.itunesButton);
            this.Controls.Add(this.DestinoButton);
            this.Controls.Add(this.CancionesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathitunesXML);
            this.Controls.Add(this.pathSyncro);
            this.Controls.Add(this.SyncroFeed);
            this.Controls.Add(this.TablaListas);
            this.Controls.Add(this.PesoListas);
            this.Controls.Add(this.PesoLista);
            this.Controls.Add(this.CancionesTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppelSync";
            this.Load += new System.EventHandler(this.FirstChargeXML);
            ((System.ComponentModel.ISupportInitialize)(this.CancionesTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackViewElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaListas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listTrackViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedFromTrackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource listViewBindingSource;
        private System.Windows.Forms.BindingSource listTrackViewBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView CancionesTabla;
        private System.Windows.Forms.BindingSource trackViewElementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label PesoLista;
        private System.Windows.Forms.Label PesoListas;
        private System.Windows.Forms.DataGridView TablaListas;
        private System.Windows.Forms.Label SyncroFeed;
        private System.Windows.Forms.Label pathSyncro;
        private System.Windows.Forms.Label PathitunesXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CancionesLabel;
        private System.Windows.Forms.BindingSource feedFromTrackBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn1;
        private FontAwesome.Sharp.IconButton DestinoButton;
        private FontAwesome.Sharp.IconButton itunesButton;
        private FontAwesome.Sharp.IconButton SyncroButton;
        private FontAwesome.Sharp.IconButton HelpBTTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    }
}

