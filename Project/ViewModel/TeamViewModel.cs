using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Runtime.CompilerServices;


namespace CCFCCricApp
{
	public class TeamViewModel : INotifyPropertyChanged
	{
		Color backgroundColorButtonA = Color.Red;
		Color backgroundColorButtonB = Color.Red;
		Color backgroundColorButtonC = Color.Red;
		ObservableCollection<string> commonList;
		public event PropertyChangedEventHandler PropertyChanged;
		public ObservableCollection<string> CommonList 
		{
			get
			{
				return commonList;
			}
			set
			{
				commonList = value;
				OnPropertyChanged();
			}
		}
		public ObservableCollection<string> Team_A_PlayersList { get; set;}
		public ObservableCollection<string> Team_B_PlayersList { get; set;}
		public ObservableCollection<string> Team_C_PlayersList { get; set;}
		public ObservableCollection<string> Team_Pro_PlayersList { get; set;}

		public Color TeamCButtonBackgroundColor
		{
			get
			{
				return backgroundColorButtonC;
			}
			set
			{
				backgroundColorButtonC = value;
				OnPropertyChanged();
			}

		}
		public Color TeamBButtonBackgroundColor
		{
			get
			{
				return backgroundColorButtonB;
			}
			set
			{
				backgroundColorButtonB = value;
				OnPropertyChanged();

			}
		}
		public Color TeamAButtonBackgroundColor
		{
			get
			{
				return backgroundColorButtonA;
			}
			set
			{
				backgroundColorButtonA = value;
				OnPropertyChanged();

			}
		}
		void ButtonClick(string buttonName)
		{
			if (buttonName.Equals("TeamB"))
			{
				TeamAButtonBackgroundColor = Color.Red;
				TeamBButtonBackgroundColor = Color.Gray;
				TeamCButtonBackgroundColor = Color.Red;
				CommonList = Team_B_PlayersList;
			}
			else if (buttonName.Equals("TeamC"))
			{
				TeamAButtonBackgroundColor = Color.Red;
				TeamBButtonBackgroundColor = Color.Red;
				TeamCButtonBackgroundColor = Color.Gray;
				CommonList = Team_C_PlayersList;
			}
			else
			{
				TeamAButtonBackgroundColor = Color.Gray;
				TeamBButtonBackgroundColor = Color.Red;
				TeamCButtonBackgroundColor = Color.Red;
				CommonList = Team_A_PlayersList;
			}
		}

		void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}

		public Command TeamButtonClick { get;}

		public TeamViewModel()
		{
			getListOfTeams();
			TeamButtonClick = new Command<string>((key) =>
                {
					ButtonClick(key);
                });

		}
		private void getListOfTeams()
		{
			CCFCCricApp.IConfigDummyResp json = DependencyService.Get<IConfigDummyResp>();
			string response = json.ReadJsonPlayerListLocalFile();
			TeamInfo teamInfo = JsonConvert.DeserializeObject<TeamInfo>(response);
			foreach (Team team in teamInfo.Team)
			{
				if (team.title.Equals("Team A"))
				{
					Team_A_PlayersList = new ObservableCollection<string>();
					foreach (Player player in team.Players)
						Team_A_PlayersList.Add(player.name);
				}
				else if (team.title.Equals("Team B"))
				{
					Team_B_PlayersList = new ObservableCollection<string>();
					foreach (Player player in team.Players)
						Team_B_PlayersList.Add(player.name);
				}
				else
				{
					Team_C_PlayersList = new ObservableCollection<string>();
					foreach (Player player in team.Players)
						Team_C_PlayersList.Add(player.name);
				}
			}
			CommonList = Team_A_PlayersList;
		}
	}
}
