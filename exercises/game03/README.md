# micro-design document

## Paragraph description
I'm basing my game off of the Black Mirror episode "Nosedive" where people are ranked off of a social credit ranking system influenced by the people around them. The goal for the player will be to raise their social score by talking to NPCs. Making NPCs with higher social scores happy will improve your social score moderately; displeasing them will do the opposite. NPCs with lower social scores will have less of an effect and it will be easier to make them happy. You will also score NPCs.

If your social score gets to zero, you get put in prison. If you get it high enough to a predetermined value, you will win something (like an apartment a la the episode).

## Technical reqs
* Needs choices in a different scene to set up the game before the main gameplay starts
* Interaction needs affect player and NPC social scores
* NPCs interacting separately would also be cool
* Code 'personalities' for each NPC (i.e. what makes them happy, what do they dislike)