package com.cegeka.DigitalSecretBox.controllers;


import com.cegeka.DigitalSecretBox.domain.secrets.Secret;
import com.cegeka.DigitalSecretBox.services.SecretService;
import com.fasterxml.jackson.annotation.JacksonInject;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;


import javax.inject.Inject;
import java.util.List;

@Controller
@RequestMapping("/Secret")
public class SecretController {
    @Inject
    private SecretService secretService;

    @RequestMapping(method = RequestMethod.GET)
    @ResponseBody
    public
    List<Secret> getAllSecrets(){return secretService.getAllSecrets();}

    @RequestMapping(method = RequestMethod.POST)
    @ResponseBody
    public void addSecret(
            @RequestParam(value = "description", required = true)String description,
            @RequestParam(value = "firstName", required = true)String firstName,
            @RequestParam(value = "lastName", required = true)String lastName){
        secretService.addSecret(description, firstName, lastName);
    }







}
