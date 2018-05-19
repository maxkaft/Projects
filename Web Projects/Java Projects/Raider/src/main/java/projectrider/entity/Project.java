package projectrider.entity;

import com.sun.scenario.effect.Identity;
import org.omg.CORBA.portable.IDLEntity;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity
@Table(name = "projects")
public class Project {

    public Project() {
    }

    public Project(String title, String description, Integer budget) {
        this.title = title;
        this.description = description;
        this.budget = budget;
    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @Column
    @NotNull
    private String  title;

    @Column
    @NotNull
    private String  description;

    @Column
    @NotNull
    private Integer budget;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Integer getBudget() {
        return budget;
    }

    public void setBudget(Integer budget) {
        this.budget = budget;
    }
}
