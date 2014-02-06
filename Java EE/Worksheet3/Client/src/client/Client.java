/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package client;

import conv.ConverterRemote;
import javax.ejb.EJB;

/**
 *
 * @author softly
 */
public class Client {
    @EJB
    private ConverterRemote conv;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Client c = new Client();
        
        System.err.println(c.conv.cTof(0D));
    }
    
}
