using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CCFCCricApp
{
	public class HomeScreenViewModel
	{
		public List<CommitteeMembers> membersList;
		public ObservableCollection<CommitteeMemberWrapper> membersListWrapper { get; set; }

		public HomeScreenViewModel()
		{
			membersList = new List<CommitteeMembers>();

			membersList.Add(new CommitteeMembers() { imageSource = "arunlal.jpg", designation = "President", displayName = "Mr. Arun Lal"});
			membersList.Add(new CommitteeMembers() { imageSource = "nvm.jpg", designation = "Sports Co-ordinator", displayName = "Mr. Navendu Mathur"});
			membersList.Add(new CommitteeMembers() { imageSource = "irfan.jpg", designation = "Captain", displayName = "Mr. Irfan Ahmed"});
			membersList.Add(new CommitteeMembers() { imageSource = "wazim.png", designation = "Vice Captain", displayName = "Mr. Wasim Aziz"});
			membersList.Add(new CommitteeMembers() { imageSource = "mainak.jpg", designation = "Joint Secy", displayName = "Mr. Mainak Choudhury"});
			membersList.Add(new CommitteeMembers() { imageSource = "Zaffy.jpg", designation = "Joint Secy", displayName = "Mr. Zafar Aziz Khan"});

			membersListWrapper = new ObservableCollection<CommitteeMemberWrapper>();

			for (int i = 0; i<membersList.Count; i++)
			{
				if (membersList.Count % 2 >= 1 )
				{
					if (i == membersList.Count - 1)
						membersListWrapper.Add(new CommitteeMemberWrapper() { memberOne = membersList[i] });
					else
					{
						membersListWrapper.Add(new CommitteeMemberWrapper() { memberOne = membersList[i], memberTwo = membersList[i + 1] });
						i = i + 1;
					}
				}
				else
				{
					membersListWrapper.Add(new CommitteeMemberWrapper() { memberOne = membersList[i], memberTwo = membersList[i + 1] });
					i = i + 1;
				}
			}
		}
	}
}
