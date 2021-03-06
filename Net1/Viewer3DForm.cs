﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using WeifenLuo.WinFormsUI.Docking;

namespace Net1
{
	public partial class Viewer3DForm : DockContent
	{
		#region Fields

		#endregion


		#region Properties

		//tool strip menu
		public bool ShowSpatialLearning { get; private set; }
		public bool ShowTemporalLearning { get; private set; }
		public bool ShowCoordinateSystem { get; private set; }
		public bool ShowActiveColumnGrid { get; private set; }
		public bool ShowPredictedGrid { get; private set; }
		public bool ShowPredictionReconstructiondGrid { get; private set; }

		//tool strip buttons
		public bool ShowCorrectPredictedCells { get; private set; }
		public bool ShowSeqPredictingCells { get; private set; }
		public bool ShowPredictingCells { get; private set; }
		public bool ShowLearningCells { get; private set; }
		public bool ShowActiveCells { get; private set; }
		public bool ShowFalsePredictedCells { get; private set; }

		#endregion


		#region Constructor

		public Viewer3DForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods


		internal IntPtr GetDrawSurface()
		{
			return this.pictureBoxSurface.Handle;
		}

		#endregion


		private void showCorrectButton_Click(object sender, EventArgs e)
		{

		}

		private void spatialLearningToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowSpatialLearning = !this.ShowSpatialLearning;
		}

		private void temporalLearningToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowTemporalLearning = !this.ShowTemporalLearning;
		}

		private void coordinateSystemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowCoordinateSystem = !this.ShowCoordinateSystem;
		}

		private void activeColumnGridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowActiveColumnGrid = !this.ShowActiveColumnGrid;
		}

		private void regionPredictionsGridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowPredictedGrid = !this.ShowPredictedGrid;
			if (this.ShowPredictedGrid)
				this.ShowPredictionReconstructiondGrid = false; //mutually exclusive since painted in the same corner

		}

		private void regionPredictionReconstructionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ShowPredictionReconstructiondGrid = !this.ShowPredictionReconstructiondGrid;
			if (this.ShowPredictionReconstructiondGrid)
				this.ShowPredictedGrid = false; //mutually exclusive since painted in the same corner
		}


		private void showCorrectButton_Click_1(object sender, EventArgs e)
		{
			this.ShowCorrectPredictedCells = !this.ShowCorrectPredictedCells;
			this.showCorrectButton.Text = this.ShowCorrectPredictedCells ? "+" : "-";
		}
		private void showSeqPredictingButton_Click(object sender, EventArgs e)
		{
			this.ShowSeqPredictingCells = !this.ShowSeqPredictingCells;
			this.showSeqPredictingButton.Text = this.ShowSeqPredictingCells ? "+" : "-";
		}

		private void showPredictingButton_Click(object sender, EventArgs e)
		{
			this.ShowPredictingCells = !this.ShowPredictingCells;
			this.showPredictingButton.Text = this.ShowPredictingCells ? "+" : "-";
		}

		private void showLearningButton_Click(object sender, EventArgs e)
		{
			this.ShowLearningCells = !this.ShowLearningCells;
			this.showLearningButton.Text = this.ShowLearningCells ? "+" : "-";
		}

		private void showActiveButton_Click(object sender, EventArgs e)
		{
			this.ShowActiveCells = !this.ShowActiveCells;
			this.showActiveButton.Text = this.ShowActiveCells ? "+" : "-";
		}

		private void showFalsePredictedButton_Click(object sender, EventArgs e)
		{
			this.ShowFalsePredictedCells = !this.ShowFalsePredictedCells;
			this.showFalsePredictedButton.Text = this.ShowFalsePredictedCells ? "+" : "-";
		}

		/// <summary>
		/// Reset camera to origina view
		/// </summary>
		private void btnResetCamera_Click(object sender, EventArgs e)
		{
			//Reset rotation angle and zoom of the camera
			Viewer3D.Engine.ResetCamera();
		}
	}
}
