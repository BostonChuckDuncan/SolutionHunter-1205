describe(' ', () => {

    it('display splash page and Nav', () => {
        cy.visit('/');
        cy.contains("Solution Hunter");
        cy.contains("Overview").click();
        cy.contains("What is Hunter").click();
        cy.contains("Overview").click();
        cy.contains('Problem').click();
        cy.contains("Overview").click();
        cy.contains('Features').click();
        cy.contains("Overview").click();
        // cy.contains('Using').click();
        // cy.contains("Overview").click();
        cy.contains('Artificial Intelligence').click();

        cy.contains("Guides").click();
        cy.contains("Examples").click();
        cy.contains("Guides").click();
        cy.contains("Tutorials").click();
        cy.contains("Guides").click();
        cy.contains("Research").click();

        // cy.contains("Contacts");
        // cy.contains("About").click();
        cy.contains("Contacts");
        cy.contains("Support").click();
        cy.contains("Contacts");
        cy.contains("Consulting Services");
        cy.contains("Contacts");
        cy.contains("Consult").click();

        cy.contains("SignUp");
        cy.contains("Login");
    });

});