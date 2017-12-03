using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TwitterAPITokenManager.Windows {
	/// <inheritdoc />
	/// <summary>
	/// タスクトレイのアイコン
	/// </summary>
	public partial class NotifyIconWrapper : Component {

		/// <summary>
		/// アイコンの初期化
		/// </summary>
		public NotifyIconWrapper() {
			InitializeComponent();

			this.show.Click += _Show_Click;
			this.exit.Click += _Exit_Click;

			this.notifyIcon.Icon = SystemIcons.Application;
		}

		public NotifyIconWrapper(IContainer container) {
			container.Add(this);

			InitializeComponent();
		}

		private static void _Show_Click(object sender, EventArgs e) => App.Instance.MainWindow?.Show();

		private static void _Exit_Click(object sender, EventArgs e) => App.Instance.Shutdown();
	}
}
