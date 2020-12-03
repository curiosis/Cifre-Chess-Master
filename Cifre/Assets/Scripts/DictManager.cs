using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DictManager : MonoBehaviour
{
    public Text textDescription, mainTitle, EnTitle;
    public Image movement;
    string[] descs = new string[8];
    string[] title1 = new string[8];
    string[] title2 = new string[8];
    Sprite[] images = new Sprite[8];
    public GameObject canvasView;

    private void Start()
    {
        descs[0] = "Czy ch³op, si³¹ zaci¹gniêty do wojska po przegranej bitwie pod Rente’l odpowiada za decyzje swoich dowódców? Czy odpowiedzialnoœæ zbiorowa to jeszcze sprawiedliwoœæ? Oczywiœcie to pytania retoryczne. Taki ch³op jest tylko i wy³¹cznie miêsem, którego jak zginie od pierwszego ciosu, op³akiwaæ nikt nie bêdzie.";
        descs[1] = "Ciii… s³yszysz? Ja te¿ nie. To mo¿e tylko oznaczaæ ¿e gdzieœ w pobli¿u s¹ zwiadowcy. Jeœli nie bêdziemy siê ruszaæ mo¿e zabij¹ nas szybko. Jeœli natomiast zaczniemy biec - ich strza³y przerobi¹ nasze cia³a w dziurawy ser.";
        descs[2] = "Szybki niczym rumak. Dok³adny niczym Lord Laroy, planuj¹cy inwazjê na królestwa pó³nocy. Waleczny niczym lew. I co najgorsze - by³y ¿o³nierz Króla Vertiego, maszyna do zabijania bez skrupu³ów.";
        descs[3] = "Wie¿e oblê¿nicze mia³y za zadanie dostarczaæ wojska atakuj¹ce w pobli¿e murów, i u³atwiæ im dostanie siê na nie. Natomiast wie¿e braci Chevalier to taran, mog¹cy poruszaæ siê z olbrzymi¹ prêdkoœci¹ - niszcz¹c wszystko na swojej drodze.";
        descs[4] = "Sprytny, bezlitosny i szybki. Goñce nie brn¹ na oœlep do przodu. Goñce lubi¹ siê bawiæ swoj¹ ofiar¹. Jeœli zobaczysz goñca, okr¹¿aj¹cego ciê - mo¿esz zacz¹æ siê modliæ o szybk¹ œmieræ - tylko ona mo¿e ciê wybawiæ od bólu, zadawanego przez Goñca.";
        descs[5] = "Na przedzie upiornego orszaku braci Chevalier gnaj¹ ogary, niczym lodowy py³ ci¹gn¹cy siê za komet¹. Ponoæ czasami gubi¹ drogê i schodz¹ z nocnego nieba na ziemiê, przynosz¹c ze sob¹ zimno i œmieræ.";
        descs[6] = "Z³ote dziecko, które wyros³o na zbrodniarza. Tak mo¿na opisaæ ka¿dego z dowódców, którzy rywalizuj¹ ze sob¹ od malca. Pewnego razu aby udowodniæ, który jest silniejszy wymordowali osiem wiosek. Nawet Samson Chevalier czu³ niekiedy przera¿enie, patrz¹c w ich puste, chêci mordu oczodo³y.";
        descs[7] = "Samson czy Albert? To tak jakby wybieraæ miêdzy z³em a z³em. Przeklêci, którzy musieli wraz ze swoim wojskiem staæ siê swoj¹ w³asn¹ gr¹. Pamiêtaj, ¿e ich zabójcy bowiem podziel¹ los wielkich braci Chevalier.";

        title1[0] = "Pion";
        title1[1] = "Zwiadowca";
        title1[2] = "£ucznik";
        title1[3] = "Wie¿a";
        title1[4] = "Goniec";
        title1[5] = "Skoczek";
        title1[6] = "Hetman";
        title1[7] = "Przeklêty";

        title2[0] = "Pawn";
        title2[1] = "Scout";
        title2[2] = "Archer";
        title2[3] = "Rook";
        title2[4] = "Bishop";
        title2[5] = "Knight";
        title2[6] = "Queen";
        title2[7] = "Cursed";

        images[0] = Resources.Load<Sprite>("PawnMv");
        images[1] = Resources.Load<Sprite>("ScoutMv");
        images[2] = Resources.Load<Sprite>("ArcherMv");
        images[3] = Resources.Load<Sprite>("RookMv");
        images[4] = Resources.Load<Sprite>("BishopMv");
        images[5] = Resources.Load<Sprite>("KnightMv");
        images[6] = Resources.Load<Sprite>("QueenMv");
        images[7] = Resources.Load<Sprite>("CursedMv");
    }

    public void Pawn()
    {
        textDescription.text = descs[0];
        mainTitle.text = title1[0];
        EnTitle.text = title2[0];
        movement.sprite = images[0];
    }

    public void Scout()
    {
        textDescription.text = descs[1];
        mainTitle.text = title1[1];
        EnTitle.text = title2[1];
        movement.sprite = images[1];
    }

    public void Archer()
    {
        textDescription.text = descs[2];
        mainTitle.text = title1[2];
        EnTitle.text = title2[2];
        movement.sprite = images[2];
    }

    public void Rook()
    {
        textDescription.text = descs[3];
        mainTitle.text = title1[3];
        EnTitle.text = title2[3];
        movement.sprite = images[3];
    }

    public void Bishop()
    {
        textDescription.text = descs[4];
        mainTitle.text = title1[4];
        EnTitle.text = title2[4];
        movement.sprite = images[4];
    }

    public void Knight()
    {
        textDescription.text = descs[5];
        mainTitle.text = title1[5];
        EnTitle.text = title2[5];
        movement.sprite = images[5];
    }

    public void Queen()
    {
        textDescription.text = descs[6];
        mainTitle.text = title1[6];
        EnTitle.text = title2[6];
        movement.sprite = images[6];
    }

    public void Cursed()
    {
        textDescription.text = descs[7];
        mainTitle.text = title1[7];
        EnTitle.text = title2[7];
        movement.sprite = images[7];
    }

    public void CanvasView()
    {
        canvasView.SetActive(false);
    }
}
