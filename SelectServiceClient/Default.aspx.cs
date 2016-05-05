using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ShowTrackerServiceRef.ShowTrackerServiceClient stc = new ShowTrackerServiceRef.ShowTrackerServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Fill_Artist_DropDown();
            Fill_Venue_DropDown();
            Fill_Show_DropDown();
        }
            
    }
    protected void Fill_Artist_DropDown()
    {
        string[] artists = stc.GetArtists();
        ArtistDropDown.DataSource = artists;
        ArtistDropDown.DataBind();
 
    }

    protected void Fill_Venue_DropDown()
    {
        string[] venues = stc.GetVenues();
        VenueDropDown.DataSource = venues;
        VenueDropDown.DataBind();
    }

    protected void Fill_Show_DropDown()
    {
        string[] shows = stc.GetShows();
        ShowDropDown.DataSource = shows;
        ShowDropDown.DataBind();
    }
    protected void SelectArtist_Click(object sender, EventArgs e)
    {
        string selectedArtist = ArtistDropDown.SelectedItem.Text;
        ShowTrackerServiceRef.Performance[] shows = stc.GetArtistShows(selectedArtist);
        ShowGridView.DataSource = shows;
        ShowGridView.DataBind();
    }



    protected void SelectVenue_Click(object sender, EventArgs e)
    {
        string selectedVenue = VenueDropDown.SelectedItem.Text;
        ShowTrackerServiceRef.Performance[] shows = stc.GetVenueShows(selectedVenue);
        ShowGridView.DataSource = shows;
        ShowGridView.DataBind();
    }

    protected void DisplayShows_Click(object sender, EventArgs e)
    {
        string[] shows = stc.GetShows();
        ShowGridView.DataSource = shows;
        ShowGridView.DataBind();
    }
}