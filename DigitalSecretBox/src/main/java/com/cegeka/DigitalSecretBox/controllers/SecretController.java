package com.cegeka.DigitalSecretBox.controllers;


import com.cegeka.DigitalSecretBox.domain.secrets.Secret;
import com.cegeka.DigitalSecretBox.services.SecretService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@Controller
@RequestMapping("/Secret")
public class SecretController {
    @Autowired
    private SecretService secretService;

    @RequestMapping(method = RequestMethod.GET)
    @ResponseBody
    public
    List<Secret> getAllSecrets(){return secretService.getAllSecrets();}

    /*@RequestMapping(method = RequestMethod.POST)
    @ResponseBody
    public*/



}
