package com.cegeka.DigitalSecretBox.domain.pineapples;

public class Pineapple {

    public String firstName;
    public String lastName;

    public Pineapple(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public static String getPineApple(Pineapple pineapple) {
        return pineapple.getFirstName()+pineapple.getLastName();
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Pineapple pineapple = (Pineapple) o;

        if (firstName != null ? !firstName.equals(pineapple.firstName) : pineapple.firstName != null) return false;
        return lastName != null ? lastName.equals(pineapple.lastName) : pineapple.lastName == null;
    }

    @Override
    public int hashCode() {
        int result = firstName != null ? firstName.hashCode() : 0;
        result = 31 * result + (lastName != null ? lastName.hashCode() : 0);
        return result;
    }
}